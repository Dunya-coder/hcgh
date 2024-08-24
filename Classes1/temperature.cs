using System;
using System.Globalization;
namespace Palindrom.Classes1;
class Temperator
{
    public double Selsius{get;set;}
    public double Kelvin{get;set;}
    public double Farangeit{get;set;}
public void CalculateTemperator()
{
    Console.WriteLine("switch temperature type:selsius,kelvin,farangeit");
    string temperator=Console.ReadLine();
    switch(temperator)
    {
        
    case "selsius":
    Selsius=double.Parse(Console.ReadLine());
    Farangeit= (9  * Selsius/5.0) + 32;
    Kelvin = Selsius + 273.15;
Console.WriteLine($"{Selsius}-selsiyus \n {Kelvin}-kelvin \n {Farangeit}-farangeyt");

    break;
    case"farangeit":
    Farangeit=double.Parse(Console.ReadLine());
    Selsius=5*(Farangeit-32)/9.0;
    Kelvin=Selsius+273.15;
Console.WriteLine($"{Selsius}-selsiyus \n {Kelvin}-kelvin \n {Farangeit}-farangeyt");

    break;
    case "kelvin":
    Kelvin=double.Parse(Console.ReadLine());
    Selsius=Kelvin-273.15;
    Farangeit=(9*Selsius/5.0)+32.0;

Console.WriteLine($"{Selsius}-selsiyus \n {Kelvin}-kelvin \n {Farangeit}-farangeyt");

    break;
    }
}


}