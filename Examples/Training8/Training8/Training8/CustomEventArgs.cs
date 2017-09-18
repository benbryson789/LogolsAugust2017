using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class CustomEventArgs : EventArgs
    {
        private string message;

        public CustomEventArgs(string input)
        {
            message = input;
        }

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}
