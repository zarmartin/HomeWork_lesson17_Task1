using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson17_Task1
{
    public class LanguageException : ApplicationException
    {
        public LanguageException(string? message = null) : base(message)  
        { 
        }
    }
}
