using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlLib.Messages
{
    public abstract class Message
    {
        public Message() { }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public override abstract string ToString();
    }
}
