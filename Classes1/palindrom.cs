using System;
using System.Globalization;
namespace Palindrom.Classes1;
class palindrom{
    public string Text{get;set;}
  
    public void CheckTextPalindrom()
    {
        System.Console.WriteLine("Text:");
        Text=Console.ReadLine();
       char[] check = Text.ToArray(); 
        int length = check.Length;
        bool palindrom1=false;
        for (int i = 0; i <= length / 2; i++)
        {
            
                if (check[length-i-1] == check[i])
                {
                    palindrom1 = true;
                }
                else 
                {
                    palindrom1=false;
                    break;
                }
            
        }
        if (palindrom1 == true)
        {
            Console.WriteLine("palindrom");
        }
        if(palindrom1==false)
        {
            Console.WriteLine("it's not palindrom (palindrom emas)");
        }
    }
}