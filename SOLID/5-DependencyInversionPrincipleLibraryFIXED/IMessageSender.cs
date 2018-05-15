namespace _5_DependencyInversionPrincipleLibraryFIXED
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}