using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_2
{
    class Auto : vehiculos
    {
        private int numeroDePuertas;

        public Auto(string marca, string modelo, int año, int kilometraje, int numeroDePuertas)
            : base(marca, modelo, año, kilometraje)
        {
            this.numeroDePuertas = numeroDePuertas;
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {marca} {modelo} se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El auto {marca} {modelo} se ha apagado.");
        }

        public override void Conducir(int km)
        {
            kilometraje += km;
            Console.WriteLine($"El auto ha sido conducido {km} km. Kilometraje total: {kilometraje} km.");
        }
    }


    class Motocicleta : vehiculos
    {
        private string tipoDeMoto;

        public Motocicleta(string marca, string modelo, int año, int kilometraje, string tipoDeMoto)
            : base(marca, modelo, año, kilometraje)
        {
            this.tipoDeMoto = tipoDeMoto;
        }

        public override void Encender()
        {
            Console.WriteLine($"La motocicleta {marca} {modelo} se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"La motocicleta {marca} {modelo} se ha apagado.");
        }

        public override void Conducir(int km)
        {
            kilometraje += km;
            Console.WriteLine($"La motocicleta ha sido conducida {km} km. Kilometraje total: {kilometraje} km.");
        }
    }


    class Camion : vehiculos
    {
        private int capacidadDeCarga;

        public Camion(string marca, string modelo, int año, int kilometraje, int capacidadDeCarga)
            : base(marca, modelo, año, kilometraje)
        {
            this.capacidadDeCarga = capacidadDeCarga;
        }

        public override void Encender()
        {
            Console.WriteLine($"El camión {marca} {modelo} se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El camión {marca} {modelo} se ha apagado.");
        }

        public override void Conducir(int km)
        {
            kilometraje += km;
            Console.WriteLine($"El camión ha sido conducido {km} km. Kilometraje total: {kilometraje} km.");
        }
    }
}
