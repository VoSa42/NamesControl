using Newtonsoft.Json;

namespace NamesControlLib.Messages
{
    public abstract class Message
    {
        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override abstract string ToString();
    }
}
