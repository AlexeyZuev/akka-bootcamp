namespace WinTail.Messages
{
    public class InputError
    {
        public InputError(string reason)
        {
            this.Reason = reason;
        }

        public string Reason { get; private set; }
    }
}