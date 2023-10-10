using net_lab2;

namespace net_lab2_tests;

public class UnitTest1
{
    [Fact]
    public void
        FormatUsdPrice_ProperFormat_ShouldReturnProperString()
    {
        var data = 0.05;
        var waitFor = "$0.05";
        var result = MyFormatter.FormatUsdPrice(data);
        for(int i = 0; i < waitFor.Length; i++)
            Assert.Equal(waitFor[i], result[i]);
    }

}