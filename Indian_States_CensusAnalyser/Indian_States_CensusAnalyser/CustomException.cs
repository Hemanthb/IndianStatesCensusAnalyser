using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indian_States_CensusAnalyser
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            INVALID_FILE,INVALID_EXTENSION,INVALID_DELIMITER,INVALID_HEADER
        }
        ExceptionType exception;
        public CustomException(ExceptionType exception,string message):base(message)
        {
            this.exception = exception;
        }
    }
}
