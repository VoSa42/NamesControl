using NamesControlLib.Errors;

namespace NamesControlLib.Messages
{
    /// <summary>
    /// Represents responding message from server to client.
    /// </summary>
    /// <param name="errorType"> Error type to handle it on the client side </param>
    /// <param name="grid"> Full updated table </param>
    public class ServerResponse(ErrorType errorType, List<NamesTableRow>? grid) : Message
    {
        public ErrorType ErrorType { get; set; } = errorType;
        public List<NamesTableRow>? Grid { get; set; } = grid;

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

            result += String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                "ID", "First Name", "Second Name");

            foreach (var row in Grid)
            {
                result += String.Format($"{{0,6}} | {{1,{Math.Abs(cellSize)}}} | {{2,{Math.Abs(cellSize)}}}\n",
                row.Id, row.FirstName, row.SecondName);
            }

            return result;
        }
    }
}
