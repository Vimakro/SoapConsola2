using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapConsolaAmori2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicioAmori.CountryInfoService servicio = new ServicioAmori.CountryInfoService();

            var informacion = servicio.FullCountryInfoAllCountries();

            Console.WriteLine("Codigo de Continente: " + informacion.FirstOrDefault().sContinentCode);
            Console.WriteLine("Codigo ISO del Pais: " + informacion.FirstOrDefault().sCurrencyISOCode);
            Console.WriteLine("Nombre del Pais: " + informacion.FirstOrDefault().sName);
            Console.WriteLine("Capital del Pais: " + informacion.FirstOrDefault().sCapitalCity);
            Console.WriteLine("Codigo de telefono: " + informacion.FirstOrDefault().sPhoneCode);
            Console.WriteLine("Bandera: " + informacion.FirstOrDefault().sCountryFlag);
            
            Console.ReadLine();
        }
    }
}
