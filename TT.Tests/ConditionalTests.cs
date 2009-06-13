using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class ConditionalTests : TestBase
    {
        #region "IF"

        [Test, Category("Unit")]
        public void IfVariable()
        {
            var data = new Dictionary<string, object> { { "variable", "Hello World" } };
            var result = Template.Process(Source("IF.variable"), data);

            Expect(result, Is.EqualTo(Output("IF.variable")));
        }

        #endregion
    }
}