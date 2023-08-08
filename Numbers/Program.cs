using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor)); // Ceiling arredonda para cima 
            Console.WriteLine(Math.Floor(valor)); // Floor arredonda para baixo
            
            
            
            // Formatação
            // Console.WriteLine(
            // valor.ToString( "C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}

// C mostra de acordo com a cultura especificada
// E04 é o formato de calculadora 
// G como se se fosse string
// N formata para número mas sem a cultura
// P formata com porcentagem
// Round arredonda
