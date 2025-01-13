using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using Microsoft.Data.SqlClient;

using NamesControlLib;
using NamesControlClient.Errors;

namespace NamesControlLib.Messages
{
    public class ServerAnswer(ErrorType errorType, List<DatabaseRaw>? grid) : Message
    {
        public ErrorType ErrorType { get; set; } = errorType;
        public List<DatabaseRaw>? Grid { get; set; } = grid;

        public override string ToString()
        {
            string result = "";
            if (ErrorType != ErrorType.None)
            {
                result += $"Error: {ErrorType}\n";
            }

            if (Grid == null) { return result; }

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
