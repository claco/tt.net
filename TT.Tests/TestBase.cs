using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace TT.Tests
{
    [TestFixture]
    public class TestBase : AssertionHelper
    {
        protected Template Template { get; set; }
        protected TemplateSettings Settings { get; set; }
        protected IDictionary<string, object> Variables { get; set; }

        [SetUp]
        public virtual void SetUp()
        {
            Variables = new Dictionary<string, object>()
                       {
                          {"StringVariable", "HelloWorld"} 
                       };
            Settings = new TemplateSettings(Variables);
            Template = new Template(Settings);
        }

        protected string Source(string fileName)
        {
            return File.ReadAllText(String.Format("..\\..\\templates\\{0}.source", fileName));
        }

        protected string Output(string fileName)
        {
            return File.ReadAllText(String.Format("..\\..\\templates\\{0}.output", fileName));
        }
    }
}