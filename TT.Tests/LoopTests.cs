using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class LoopTests : TestBase
    {
        #region "FOREACH"

        [Test, Category("Unit")]
        public void ForEachVariable()
        {
            var collection = new Collection<string> { "foo", "bar", "baz" };
            var data = new Dictionary<string, object> { { "variable", collection } };
            var result = Template.Process(Source("FOREACH.variable"), data);

            Expect(result, Is.EqualTo(Output("FOREACH.variable")));
        }

        #endregion
    }
}