namespace Greet.Data;

// Sent by an adapter. Name is display text the adapter chose (Discord sends a mention
// like <@123>); the world never interprets it, so no Discord ids or objects leak in.
public partial struct GreetRequest
{
    public string Message;
    public string Name;
}

// Added by GreetSystem to the same entity.
public partial struct GreetResponse
{
    public string Text;
}
