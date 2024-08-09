using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares_POO_2
{
    abstract class vehiculos
    {
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected int año { get; set; }
        protected int kilometraje { get; set; }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(int km);

        public vehiculos(string marca, string modelo, int año, int kilometraje)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.kilometraje = kilometraje;
        }
    }
}
