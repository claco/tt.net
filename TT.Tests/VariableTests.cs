using System.IO;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class VariableTests : TestBase
    {
        [Test, Category("Unit")]
        public void CanProcessVariable()
        {
            var result = Template.Process( Source("GET") );

            Expect( result, Is.EqualTo( Output("GET") ));
        }
    }
}