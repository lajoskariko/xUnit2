
using System.Reflection;

namespace xUnitTesting;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var test = "Hello, m friend";
        var actual = Program.Hello();
        Assert.Equal(test, actual);
    }
}

