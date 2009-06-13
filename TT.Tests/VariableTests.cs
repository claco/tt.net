using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class VariableTests : TestBase
    {
        #region "GET"

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

        #endregion

        #region "SET"

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

        [Test, Category("Unit")]
        public void SetMultipleVariables()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("SET.multiple"), data);

            Expect(result, Is.EqualTo(Output("SET.multiple")));
            Expect(data["foo"], Is.EqualTo("Hello World"));
            Expect(data["bar"], Is.EqualTo(5));
            Expect(data["baz"], Is.EqualTo(42.95));
            Expect(data.Count, Is.EqualTo(3));
        }

        #endregion

        #region "DEFAULT"

        [Test, Category("Unit")]
        public void DefaultLiteralVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("DEFAULT.literal"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.literal")));
            Expect(data["variable"], Is.EqualTo("Hello World"));
            Expect(data.Count, Is.EqualTo(1));
        }

        [Test, Category("Unit")]
        public void DefaultNumberVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("DEFAULT.number"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.number")));
            Expect(data["variable"], Is.EqualTo(5));
        }

        [Test, Category("Unit")]
        public void DefaultDecimalVariable()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("DEFAULT.decimal"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.decimal")));
            Expect(data["variable"], Is.EqualTo(42.95));
        }

        [Test, Category("Unit")]
        public void DefaultSetsWhenNull()
        {
            var data = new Dictionary<string, object>() { {"variable", null} };
            var result = Template.Process(Source("DEFAULT.literal"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.literal")));
            Expect(data["variable"], Is.EqualTo("Hello World"));
        }

        [Test, Category("Unit")]
        public void DefaultIgnoresNotNull()
        {
            var data = new Dictionary<string, object>() { { "variable", "Exists" } };
            var result = Template.Process(Source("DEFAULT.literal"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.literal")));
            Expect(data["variable"], Is.EqualTo("Exists"));
        }

        [Test, Category("Unit")]
        public void DefaultMultipleVariables()
        {
            var data = new Dictionary<string, object>();
            var result = Template.Process(Source("DEFAULT.multiple"), data);

            Expect(result, Is.EqualTo(Output("DEFAULT.multiple")));
            Expect(data["foo"], Is.EqualTo("Hello World"));
            Expect(data["bar"], Is.EqualTo(5));
            Expect(data["baz"], Is.EqualTo(42.95));
            Expect(data.Count, Is.EqualTo(3));
        }

        #endregion
    }
}