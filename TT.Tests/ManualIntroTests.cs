using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace TT.Tests
{
    [TestFixture]
    public class ManualIntroTests : TestBase
    {
        [Test, Category("Unit")]
        public void DearTheManagement()
        {
            var data = new Dictionary<string, object>
                           {
                               {"name", "Christopher"},
                               {"debt", "$100"},
                               {"deadline", "1/1/2010"}
                           };
            var result = Template.Process(Source("manual-intro-1"), data);

            Expect(result, Is.EqualTo(Output("manual-intro-1")));
        }
    }
}