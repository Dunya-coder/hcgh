using System;
namespace vscode
{
 class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("write word:");
        string text = Console.ReadLine();
        bool palindrom = false;
        char[] check = text.ToArray();
        int length = check.Length;
        for (int i = 0; i <= length / 2; i++)
        {
            
                if (check[length-i-1] == check[i])
                {
                    palindrom = true;
                }
                else 
                {
                    palindrom=false;
                    break;
                }
            
        }
        if (palindrom == true)
        {
            System.Console.WriteLine("palindrom");
        }
        if(palindrom==false)
        {
            System.Console.WriteLine("palindrom emas");
        }
    }
}
}