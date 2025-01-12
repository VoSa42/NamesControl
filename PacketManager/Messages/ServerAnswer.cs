using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Microsoft.Data.SqlClient;

namespace NamesControlLib.Messages
{
    public class ServerAnswer(string? errorMessage, List<DatabaseRaw> grid) : Message
    {
        public string? ErrorMessage { get; } = errorMessage;
        public List<DatabaseRaw> Grid { get; internal set; } = grid;

        private void AddRaw(int id, string firstName, string secondName)
        {
            Grid.Add(new(id, firstName, secondName));
        }

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
                if (row.FirstName.Length > cellSize) { cellSize = row.FirstName.Length; }
                if (row.SecondName.Length > cellSize) { cellSize = row.SecondName.Length; }
            }

            Console.WriteLine(String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                "ID", "First Name", "Second Name"));

            foreach (var row in Grid)
            {
                result += String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                row.Id, row.FirstName, row.SecondName);
            }

            return result;
        }
    }
}
