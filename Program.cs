// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Podaj wyniki z matematyki...");
int match = Int32.Parse(Console.ReadLine());
Console.WriteLine("Podaj wyniki z fizyki...");
int phisics  = Int32.Parse(Console.ReadLine()); 
Console.WriteLine("Podaj wyniki z chemii...");
int chemistry = Int32.Parse(Console.ReadLine());

if ((match > 70 || phisics > 55 || chemistry > 45) && (match + phisics + chemistry > 180) && (match + phisics > 150 )&& (match + chemistry > 150))
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji"); 
}
else 
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
};
