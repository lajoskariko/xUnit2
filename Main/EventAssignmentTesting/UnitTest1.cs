using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace EventAssignmentTesting;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var expected = "Hello, my friend";
        var actual = Program.HelloFriend();
        Assert.Equal(expected,actual);
    }
}