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
    }
}