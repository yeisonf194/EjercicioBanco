using System;

namespace Prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            double intereses = 2;
            double interes = (17000000 * intereses) / 100;
            double cuota = (17000000+interes) / 12;
            int total = 0;
            int y = 1;
            DateTime consignacion;
            Console.WriteLine("**********Bienvenido a Banco BBVA**********");
            Console.WriteLine("Ingrese la fecha de consignacion con el siguiente formato dd/MM/yyyy");
            consignacion = Convert.ToDateTime(Console.ReadLine());
            while(y>0 && y <= 12) {
                int year = consignacion.Year;
                int month = consignacion.Month;
                int day = consignacion.Day;
                int dayMonth = DateTime.DaysInMonth(year, month);
                int diasHabiles = dayMonth - dayMonth + 5;
                if (day > diasHabiles)
                {
                    double recargo = cuota;
                    for (int x = diasHabiles; x <= day; x++)
                    {
                        intereses = intereses + 0.02;
                        interes = (17000000 * intereses) / 100;
                        cuota = (17000000 + interes) / 12;
                        total = Convert.ToInt32(cuota);
                    }
                    int saldo = Convert.ToInt32(17000000 + interes - total);
                    Console.WriteLine($"Saldo a pagar: {saldo}");
                    Console.WriteLine($"Valor a pagar: {total}");
                }
                y++;
                Console.WriteLine("Ingrese la fecha de consignacion con el siguiente formato dd/MM/yyyy");
                consignacion = Convert.ToDateTime(Console.ReadLine());
            }
        }
    }
}
