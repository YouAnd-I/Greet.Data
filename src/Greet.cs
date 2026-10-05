namespace Discord.Greet.Data;

public partial struct GreetRequestTag;

public partial struct GreetInput
{
    public ulong UserId;
    public string Display;
    public string Message;
}

public partial struct GreetResponse
{
    public string Text;
}
