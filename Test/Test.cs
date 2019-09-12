using Xunit;

using AltCoverSwitchCaseTest;

namespace AltCoverSwitchCaseTest.Test
{
    public class Test
    {
        [Theory]
		[InlineData("a", "a")]
		[InlineData("b", "b")]
		[InlineData("c", "c")]
		[InlineData("z", "d")]
		//[InlineData(null, "d")]
        public void Test1(string value, string expected)
        {
			string result = Foo.Bar(value);
			Assert.Equal(expected, result);
        }
    }
}
