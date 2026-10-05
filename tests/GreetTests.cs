using Xunit;

namespace Discord.Greet.Data.Tests;

public class GreetInputTests
{
    [Fact]
    public void GreetInput_CarriesUserAndMessage()
    {
        var input = new GreetInput { UserId = 42, Display = "<@42>", Message = "hello" };

        Assert.Equal(42ul, input.UserId);
        Assert.Equal("<@42>", input.Display);
        Assert.Equal("hello", input.Message);
    }
}
