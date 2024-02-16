using System;
using System.Threading;


namespace Tarea_1
{
    abstract class Transporte
    {
        #region atributos
        private byte Llantas;
        private string volMotor;
        private string marca;
        private string tipo;
        private float velocidad = 0;



        #endregion

        #region Propiedades

        public byte NumLlantas { get => Llantas; set { Llantas = value; } }
        public string VolMotor { get => volMotor; set { volMotor = value; } }
        public string Marca { get => marca; set { marca = value; } }
        public string Tipo { get => tipo; set { tipo = value; } }
        public float Velocidad { get => velocidad; set { velocidad = value; } }

        #endregion

        #region metodos

        internal virtual void Saludar()
        {
            Console.WriteLine("Hola mi Transporte es {0}\nTiene {1} llantas de la marca {2} con un volumen del motor de: {3}\n", Tipo, NumLlantas, Marca, VolMotor);
            MVel();
        }

            public void LimpiarDisplay()
            {
                Thread.Sleep(1000);
                Console.Clear();
            }

                internal virtual void Acelerar()
                {
                    if (Velocidad == 150)
                    {
                        Console.WriteLine("TU {0} NO PUEDE ACELERAR MAS",Tipo);
                    }
                    else 
                    {
                        Velocidad = Velocidad + 10;
                        Console.WriteLine("Tu Velocidad es: {0}", Velocidad);
                    }
                }

                    internal virtual void Frenar()
                    {
                        if (Velocidad == 0)
                        {
                            Console.WriteLine("NO SE PUEDE FRENAR MAS YA ESTAS DETENIDO");
                        }
                        else 
                        {
                            Velocidad = Velocidad - 10;
                            Console.WriteLine("Tu Velocidad es: {0}", Velocidad);
                        }
                       
                    }

                        internal virtual void MVel()
                        {
                            short opcion = 0;
                            
                            if (Velocidad <0)
                            {
                                LimpiarDisplay();
                                Console.WriteLine("LA OPCION INGRESADA NO ES VALIDA INTENTE DE NUEVO");
                                MVel();
                            }
                                else if (Velocidad > 150 && Velocidad <200)
                                {
                                    LimpiarDisplay();
                                    Console.WriteLine("LA OPCION INGRESADA NO ES VALIDA INTENTE DE NUEVO");
                                    MVel();
                                }

                                else
                                {
                                    while (Velocidad >= 0 && Velocidad <= 150)
                                    {
                                        Console.WriteLine("Indica la velocidad a la que va tu trasnporte (En un rango de 0 a 150):");
                                        Velocidad = Convert.ToSingle(Console.ReadLine());
                                        Console.WriteLine("¿Que accion desea realizar? \n1.-Acelerar\n2.-Frenar\n3.-Salir del menu:");
                                        opcion = Convert.ToInt16(Console.ReadLine());

                                        switch (opcion)
                                        {
                                            case 1:
                                                Acelerar();
                                                break;

                                            case 2:
                                                Frenar();
                                                break;

                                            case 3:
                                                Salir();
                                            break;

                                            default:
                                                Console.WriteLine("OPCION NO VALIDA HASTA LUEGO");
                                                LimpiarDisplay();
                                                break;
                                        }
                                    }
                                }
                        }
        public void Salir ()
        {
            Console.WriteLine("Hasta Luego");
            Velocidad = 200;

        }

            public Transporte()
            {
                
                Saludar();
            }
            #endregion

        }
    }

