using HomeWork_lesson13_Task1;
using HomeWork_lesson17_Task1;
using System;

{
    try
    {
        string text1 = "Всем добрый вечер!";
        string text2 = "Good evening everyone!";

        char ch = '?';
        int indexOfChar = text1.IndexOf(ch);

        var dot = string.Equals(text1, text2);
        if (indexOfChar == -1)
        {
            throw new MySymbolException();
        }
        if  (dot == false)
        {
            throw new LanguageException();
        }


    }

    catch (MySymbolException)
    {
        Console.WriteLine("The text does not contain such a symbol!");
    }

    catch (LanguageException)
    {
        Console.WriteLine("Language does not match");
    }

    finally 
    { 
        Console.WriteLine("The end successful!"); 
    }
   
    
    
    
}



