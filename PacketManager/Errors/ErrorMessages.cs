using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesControlClient.Errors
{
    using ErrorList = List<Tuple<ErrorType, string?>>;

    public static class ErrorMessages
    {
        private static ErrorList EList { get; } = [
            new(ErrorType.None, null),
            new(ErrorType.ServerNotResponse, ErrorType.ServerNotResponse.ToString() + ": Server is not responding at the moment pleas try it later."),
            new(ErrorType.RecordNotExist, ErrorType.RecordNotExist.ToString() + ": Selected record does not exist in the database already."),
            new(ErrorType.InvalidQuery, ErrorType.InvalidQuery.ToString() + ": SQL query was incorrect."),
            ];

        public static string? GetErrorMessage(ErrorType errorType)
        {
            foreach (var error in EList)
            {
                if (error.Item1 == errorType) { return error.Item2; }
            }
            throw new Exception("Unknown Error");
        }
    }
}
