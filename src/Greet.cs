namespace Greet.Data;

public partial struct GreetRequest
{
    public string Message;
    public string Name;
}

public partial struct GreetResponse
{
    public string Text;
}
