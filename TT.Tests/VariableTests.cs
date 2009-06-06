using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class VariableTests : TestBase
    {
        [Test, Category("Unit")]
        public void GetLiteralVariable()
        {
            var result = Template.Process( Source("GET.literal") );

            Expect( result, Is.EqualTo( Output("GET.literal") ));
        }

        [Test, Category("Unit")]
        public void GetVariable()
        {
            var data = new Dictionary<string, object> { {"variable", "Hello World"} };
            var result = Template.Process(Source("GET.variable"), data);

            Expect(result, Is.EqualTo(Output("GET.variable")));
        }

        [Test, Category("Unit")]
        public void ImpliedGetVariable()
        {
            var data = new Dictionary<string, object> { { "variable", "Hello World" } };
            var result = Template.Process(Source("GET.implied.variable"), data);

            Expect(result, Is.EqualTo(Output("GET.implied.variable")));
        }

        [Test, Category("Unit")]
        public void SetLiteralVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("SET.literal"), data);

            Expect(result, Is.EqualTo(Output("SET.literal")));
            Expect(data["variable"], Is.EqualTo("Hello World"));
        }

        [Test, Category("Unit")]
        public void ImpliedSetVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("SET.implied.literal"), data);

            Expect(result, Is.EqualTo(Output("SET.implied.literal")));
        }

        [Test, Category("Unit")]
        public void SetNumberVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("SET.number"), data);

            Expect(result, Is.EqualTo(Output("SET.number")));
            Expect(data["variable"], Is.EqualTo(5));
        }

        [Test, Category("Unit")]
        public void SetDecimalVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("SET.decimal"), data);

            Expect(result, Is.EqualTo(Output("SET.decimal")));
            Expect(data["variable"], Is.EqualTo(42.95));
        }
    }
}