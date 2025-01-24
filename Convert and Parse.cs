using System;

namespace PracticasCSharp
{ 
    class ConvertAndParse
    {
        static void Main(string [] args)
        {
            int primerNumero;
            int segundoNumero;

            Console.WriteLine("Introduce primer numero: ");
            primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce segundo numero: ");
            segundoNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de " + primerNumero +" + "+ segundoNumero + " es: "+(primerNumero+segundoNumero));
            Console.WriteLine("El resultado de " + primerNumero + " - " + segundoNumero + " es: " + (primerNumero - segundoNumero));
            Console.WriteLine("El resultado de " + primerNumero + " * " + segundoNumero + " es: " + (primerNumero * segundoNumero));
            double primerNumeroDecimal = Convert.ToDouble(primerNumero);
            double segundoNumeroDecimal = Convert.ToDouble(segundoNumero);
            Console.WriteLine("El resultado de " + primerNumeroDecimal + " / " + segundoNumeroDecimal + " es: " + (primerNumeroDecimal / segundoNumeroDecimal));
             
        }
    }

}
