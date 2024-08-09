using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Toyota", "Corolla", 2021, 30000, 4);
            Motocicleta miMoto = new Motocicleta("Honda", "CBR600", 2022, 5000, "Deportiva");
            Camion miCamion = new Camion("Mercedes-Benz", "Actros 2644", 2020, 75000, 12000);

            miAuto.Encender();
            miAuto.Conducir(150);
            miAuto.Apagar();
            Console.WriteLine();

            miMoto.Encender();
            miMoto.Conducir(100);
            miMoto.Apagar();

            miCamion.Encender();
            miCamion.Conducir(200);
            miCamion.Apagar();
            Console.WriteLine();
        }
    }
}