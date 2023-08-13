using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson13_Task1
{
   public class MySymbolException : Exception
    {
        
        public MySymbolException(string? message = null) : base(message) 
        { 
        }
        

    }

}
