using System.Collections.Generic;
using System.Linq;

using Xunit;

using AltCoverSwitchCaseTest;

namespace AltCoverSwitchCaseTest.Test
{
    public class Test
    {
        [Theory]
		[InlineData(new string[] { "a", "b", "c", "z" }, new string[] { "a", "b", "c", "d" })]
		[InlineData(new string[] { "a", "b", "c", null, "" }, new string[] { "a", "b", "c" })]
		//[InlineData(null, "d")]
        public void Test1(string[] values, string[] expected)
        {
			List<string> result = Foo.Bar(values.ToList());
			Assert.Equal(expected, result);
        }
    }
}
