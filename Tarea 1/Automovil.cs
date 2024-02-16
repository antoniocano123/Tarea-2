using System;

namespace Tarea_1
{
    internal class Automovil : Transporte
    {
        internal override void Saludar()
        {
            VolMotor = "5.8L";
            NumLlantas = 4;
            Marca = "Ford Mustang";
            Tipo = "Automovil";
            base.Saludar();
        }
        public Automovil()
        {
            Saludar();
        }

    }
}