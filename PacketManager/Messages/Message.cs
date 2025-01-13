using Newtonsoft.Json;

namespace NamesControlLib.Messages
{
    /// <summary>
    /// Parent member for all different (meant two at this time) messages to be
    /// stated for network transportation.
    /// </summary>
    public abstract class Message
    {
        public override abstract string ToString();
    }
}
