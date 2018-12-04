using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHotel.Dtos
{
    public class ErrorDto
    {
        string errorValue = string.Empty;
        string typeValue = string.Empty;
        string codeValue = string.Empty;

        public string Error
        {
            get { return errorValue; }
            set { errorValue = value; }
        }

        public string Type
        {
            get { return typeValue; }
            set { typeValue = value; }
        }

        public string Code
        {
            get { return codeValue; }
            set { codeValue = value; }
        }
    }
}
