using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace NamesControlLib.Messages
{
    public class ServerAnswer : Message
    {
        public string? ErrorMessage { get; } = null;
        public (int, string, string)[] Grid { get; } = { };

        public override string ToString()
        {
            string result = "";
            if (ErrorMessage != null)
            {
                result += "Error: " + ErrorMessage;
            }

            int cellSize = 11;
            foreach (var row in Grid)
            {
                if (row.Item2.Length > cellSize) { cellSize = row.Item2.Length; }
                if (row.Item3.Length > cellSize) { cellSize = row.Item3.Length; }
            }

            Console.WriteLine(String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                "ID", "First Name", "Second Name"));

            foreach (var row in Grid)
            {
                result += String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                row.Item1, row.Item2, row.Item3);
            }

            return result;
        }
    }
}
