using System;
using System.Globalization;
namespace Palindrom.Classes1;
class Sort
{
    public int Numbers{get;set;}
    public void Switch()
    {
        System.Console.WriteLine("switch :"
        +"ascendingOrder(o'sish tartibida)"
        +"\n decendingOrder(kamayish tartibida)");
        string type=Console.ReadLine();
       if(type=="ascendingOrder")
       {
        AscendingOrder();
       }
       if(type=="dr")
       {
        DescendingOrder();
       }
    }
    public void AscendingOrder()
    {
int ii,jj;
Console.WriteLine(" Enter numbers:");
Numbers = int.Parse(Console.ReadLine());
        
        char[] char_array = Numbers.ToString().ToCharArray();
        
      
        int[] a = char_array.Select(c => int.Parse(c.ToString())).ToArray();
        int c=0;
         
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] > a[j])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                }
            }
            Console.WriteLine("Array sorted");
           
for( int i=0;i<a.Length;i++)
{
    Console.WriteLine(a[i]);
}
    }
    public void DescendingOrder()
    {
     Console.WriteLine(" Enter numbers");

     Numbers = int.Parse(Console.ReadLine());
        
        char[] char_array = Numbers.ToString().ToCharArray();
        
      
        int[] a = char_array.Select(c => int.Parse(c.ToString())).ToArray();
        int c=0;
         
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] < a[j])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                }
            }
            Console.WriteLine("Array sorted!");
           
            for( int i=0;i<a.Length;i++)
            {
               System.Console.WriteLine(a[i]);
            }

        
    }
}