using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Antlr.StringTemplate;
using Compiler = System.CodeDom.Compiler;
using Microsoft.CSharp; 


namespace TT
{
    public class Template
    {
        protected TemplateSettings Settings { get;private set; }

        public Template(TemplateSettings settings)
        {
            Settings = settings;
        }

        public string Process(string template)
        {
            return this.Process(template, null);
        }

        public string Process(string template, Dictionary<string, object> variables)
        {
            //This is a hack, but it removes the need for a step to separate html from tt
            //by treating it all as literals
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(template);
            template = string.Concat("[%'", template.Replace("[%", "'^^][%").Replace("%]", "%][%'").Replace("'^^]", "'%]"), "'%]");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(template);
            Console.WriteLine("--------------------------------------------");


            //CSharpTarget.stg contains string templates used for targeting C#
            //TextReader stgReader = new StreamReader(File.Open("CSharpGenerator.stg", FileMode.Open));
            TextReader stgReader = new StreamReader("CSharpGenerator.stg");
            StringTemplateGroup stg = new StringTemplateGroup(stgReader);

            //lex
            ICharStream input = new ANTLRStringStream(template);
            TemplateLexer lex = new TemplateLexer(input);

            //parse
            TemplateParser parse = new TemplateParser(new CommonTokenStream(lex));
            TemplateParser.document_return parseRet = parse.document();

            Console.WriteLine(( (CommonTree) parseRet.Tree).ToStringTree());

            //generate C#
            ITreeNodeStream nodeStream = new CommonTreeNodeStream(parseRet.Tree);
            CSharpGenerator gen = new CSharpGenerator(nodeStream);
            gen.TemplateLib = stg;
            CSharpGenerator.document_return ret = gen.document();

            //compile to executable and optionally run
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(ret.Template.ToString());
            Console.WriteLine("--------------------------------------------");


            // compile and run it
            var inMemory = true;
            Assembly assembly = Generate(ret.Template.ToString(), "", inMemory);
            if (inMemory)
            {
                //assembly.EntryPoint.Invoke(null, new object[] { new string[] { } });
                var o = assembly.CreateInstance("x");
                Object[] args = {this.Settings, variables};
                var result = o.GetType().InvokeMember("Render", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, o, args);

                return result.ToString();
            } 


            return "";
        }


        static Assembly Generate(string code, string name, bool inMemory)
        {
            inMemory = true;
            //TODO - allow specification of output dir
            string outputDir = Directory.GetCurrentDirectory();

            //dump the generated code
            using (FileStream fs = File.OpenWrite(Path.Combine(outputDir, name + ".lol.cs")))
            {
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(code);
                writer.Flush();
                writer.Close();
            }

            Compiler.CompilerParameters compilerParams = new Compiler.CompilerParameters();
            compilerParams.GenerateInMemory = inMemory;
            if (!inMemory)
            {
                compilerParams.OutputAssembly = Path.Combine(outputDir, name + ".exe");
            }


            compilerParams.ReferencedAssemblies.Add("TT.dll");
            compilerParams.TreatWarningsAsErrors = false;
            compilerParams.CompilerOptions = "/optimize";
            //compilerParams.MainClass = "x";
            compilerParams.GenerateExecutable = false;
            compilerParams.GenerateInMemory = true;

            var compilerOptions = new Dictionary<string, string> { { "CompilerVersion", "v3.5" } };
            CSharpCodeProvider provider = new CSharpCodeProvider(compilerOptions);
            Compiler.CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, code);

            if (results.Errors.HasErrors)
            {
                foreach (var error in results.Errors)
                {
                    Debug.WriteLine(error.ToString());
                }

                throw new Exception("Internal compiler error."); //this means a bug in our compiler, not the user's code
            }

            return results.CompiledAssembly;
        }

    }
}