using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.TP2.Ejercicio2
{
    class Test
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Motor m1 = new Motor();
            Ruedas r1 = new Ruedas();
            CajadeCambios c1 = new CajadeCambios();

            Console.Write("Ingrese Tipo de Vehiculo 1: Auto / Camion / Moto: ");
            v1.Tdv = Console.ReadLine();
            Console.Write("Ingrese Marcar del " + v1.Tdv +": ");
            v1.Marca = Console.ReadLine();
            Console.Write("Ingrese Modelo del " + v1.Tdv + ": ");
            v1.Modelo = Console.ReadLine();
            Console.Write("Ingrese Año del " + v1.Tdv + ": ");
            v1.Anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Cilindradas del Motor: ");
            m1.Cilindradas = int.Parse(Console.ReadLine());

            //-----------------------------------------------------------------------
            Console.Write("Ingrese Diametro de Ruedas: ");
            r1.Diametro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Ruedas: ");
            Console.Write("\nAuto maximo 5 " + "\nMoto maximo 3" + "\nCamion maximo 10: ");
            r1.CantidadDeRuedas = int.Parse(Console.ReadLine());

            if (v1.Tdv == "auto" || v1.Tdv == "Auto") {
                do
                {
                 
                
                    if (r1.CantidadDeRuedas > 5 || r1.CantidadDeRuedas < 4)
                    {
                    Console.Write("El " + v1.Tdv + " no puede tener más de 5 ruedas ni menos de 4.");
                    Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                    r1.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                
                } while (r1.CantidadDeRuedas < 4 || r1.CantidadDeRuedas > 5);
            }


            if (v1.Tdv == "moto" || v1.Tdv == "Moto")
            {
                do
                {
                
                
                    if (r1.CantidadDeRuedas > 2 )
                    {
                        Console.Write("El " + v1.Tdv + " no puede tener más de 3 ruedas ni menos de 2.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r1.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r1.CantidadDeRuedas < 2 || r1.CantidadDeRuedas > 3);
            }


            if (v1.Tdv == "camion" || v1.Tdv == "Camion")
            {
                do
                {
                     if (r1.CantidadDeRuedas > 10)
                     {
                         Console.Write("El " + v1.Tdv + " no puede tener más de 10 ruedas ni menos de 4.");
                         Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                         r1.CantidadDeRuedas = int.Parse(Console.ReadLine());
                      }
                } while (r1.CantidadDeRuedas < 4 || r1.CantidadDeRuedas > 10);
            }

            //-------------------------------------------------------------------------------------------
            if (v1.Tdv == "auto" || v1.Tdv == "camion" || v1.Tdv == "Camion" || v1.Tdv == "Auto")
            {
                Console.Write("Ingresar cantidad de cambios de la caja: ");
                c1.CantidadCambios = int.Parse(Console.ReadLine());

                do
                {
                    if (c1.CantidadCambios > 6)
                    {
                        Console.Write("El automovil/camion no puede tener mas de 6 cambios (Incluida la reversa)");
                        Console.Write("\nIngrese nuevamente la cantidad de cambios: ");
                        c1.CantidadCambios = int.Parse(Console.ReadLine());
                    }
                } while (c1.CantidadCambios < 6);

                Console.Write("Ingrese tipo de transmision: Automatico/Manual: ");
                c1.Tipo = Console.ReadLine();
                if (!c1.Tipo.Equals("manual") && !c1.Tipo.Equals("automatico"))
                {
                    do
                    {
                        Console.Write("Unicamente la transmision puede ser Automatico o Manual.");
                        Console.Write("\nPor favor ingresar nuevamente el tipo de transmision del vehiculo: ");
                        c1.Tipo = Console.ReadLine();
                    } while (!c1.Tipo.Equals("manual") && !c1.Tipo.Equals("automatico"));

                } 
            }
            Console.Write("   ");
            Console.Write("El Vehiculo 1 es un: " + v1.Tdv + "\nMarcar:  " + v1.Marca + "\nModelo: " + v1.Modelo + "\nAño: " + v1.Anio + "\nCon un motor de " + m1.Cilindradas + " Cilindaras" + "\ny Una caja de " + c1.CantidadCambios + " Cambios " + " " + c1.Tipo + "\nEquipado con " + r1.CantidadDeRuedas + " Ruedas, de un diametro de " + r1.Diametro + ".");
            Console.ReadKey();
            Console.Write("   ");
            Console.Write("   ");


            Vehiculo v2 = new Vehiculo();
            Motor m2 = new Motor();
            Ruedas r2 = new Ruedas();
            CajadeCambios c2 = new CajadeCambios();
            
            Console.Write("Ingrese Tipo de Vehiculo 1: Auto / Camion / Moto: ");
            v2.Tdv = Console.ReadLine();
            Console.Write("Ingrese Marcar del " + v1.Tdv +": ");
            v2.Marca = Console.ReadLine();
            Console.Write("Ingrese Modelo del " + v1.Tdv + ": ");
            v2.Modelo = Console.ReadLine();
            Console.Write("Ingrese Año del " + v1.Tdv + ": ");
            v2.Anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Cilindradas del Motor: ");
            m2.Cilindradas = int.Parse(Console.ReadLine());

            //-----------------------------------------------------------------------
            Console.Write("Ingrese Diametro de Ruedas: ");
            r2.Diametro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Ruedas: ");
            Console.Write("\nAuto maximo 5 " + "\nMoto maximo 3" + "\nCamion maximo 10: ");
            r2.CantidadDeRuedas = int.Parse(Console.ReadLine());

            if (v2.Tdv == "auto" || v2.Tdv == "Auto") {
                do
                {
                 
                
                    if (r2.CantidadDeRuedas > 5 || r2.CantidadDeRuedas < 4)
                    {
                    Console.Write("El " + v2.Tdv + " no puede tener más de 5 ruedas ni menos de 4.");
                    Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                    r2.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                
                } while (r2.CantidadDeRuedas < 4 || r2.CantidadDeRuedas > 5);
            }


            if (v2.Tdv == "moto" || v2.Tdv == "Moto")
            {
                do
                {
                
                
                    if (r2.CantidadDeRuedas > 2 )
                    {
                        Console.Write("El " + v2.Tdv + " no puede tener más de 3 ruedas ni menos de 2.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r2.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r2.CantidadDeRuedas < 2 || r2.CantidadDeRuedas > 3);
            }


            if (v2.Tdv == "camion" || v2.Tdv == "Camion")
            {
                do
                {
                     if (r2.CantidadDeRuedas > 10)
                     {
                         Console.Write("El " + v2.Tdv + " no puede tener más de 10 ruedas ni menos de 4.");
                         Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                         r2.CantidadDeRuedas = int.Parse(Console.ReadLine());
                      }
                } while (r2.CantidadDeRuedas < 4 || r2.CantidadDeRuedas > 10);
            }

            //-------------------------------------------------------------------------------------------
            if (v2.Tdv == "auto" || v2.Tdv == "camion" || v2.Tdv == "Camion" || v2.Tdv == "Auto")
            {
                Console.Write("Ingresar cantidad de cambios de la caja: ");
                c2.CantidadCambios = int.Parse(Console.ReadLine());

                do
                {
                    if (c2.CantidadCambios > 6)
                    {
                        Console.Write("El automovil/camion no puede tener mas de 6 cambios (Incluida la reversa)");
                        Console.Write("\nIngrese nuevamente la cantidad de cambios: ");
                        c2.CantidadCambios = int.Parse(Console.ReadLine());
                    }
                } while (c2.CantidadCambios < 6);

                Console.Write("Ingrese tipo de transmision: Automatico/Manual: ");
                c2.Tipo = Console.ReadLine();
                if (!c2.Tipo.Equals("manual") && !c2.Tipo.Equals("automatico"))
                {
                    do
                    {
                        Console.Write("Unicamente la transmision puede ser Automatico o Manual.");
                        Console.Write("\nPor favor ingresar nuevamente el tipo de transmision del vehiculo: ");
                        c2.Tipo = Console.ReadLine();
                    } while (!c2.Tipo.Equals("manual") && !c2.Tipo.Equals("automatico"));

                } 
            }
            Console.Write("   ");
            Console.Write("El Vehiculo 2 es un: " + v2.Tdv + "\nMarcar:  " + v2.Marca + "\nModelo: " + v2.Modelo + "\nAño: " + v2.Anio + "\nCon un motor de " + m2.Cilindradas + " Cilindaras" + "\ny Una caja de " + c2.CantidadCambios + " Cambios " + " " + c2.Tipo + "\nEquipado con " + r2.CantidadDeRuedas + " Ruedas, de un diametro de " + r2.Diametro + ".");
            Console.ReadKey();
            Console.Write("   ");
            Console.Write("   ");



            Vehiculo v3 = new Vehiculo();
            Motor m3 = new Motor();
            Ruedas r3 = new Ruedas();
            CajadeCambios c3 = new CajadeCambios();

            Console.Write("Ingrese Tipo de Vehiculo 1: Auto / Camion / Moto: ");
            v3.Tdv = Console.ReadLine();
            Console.Write("Ingrese Marcar del " + v1.Tdv + ": ");
            v3.Marca = Console.ReadLine();
            Console.Write("Ingrese Modelo del " + v1.Tdv + ": ");
            v3.Modelo = Console.ReadLine();
            Console.Write("Ingrese Año del " + v1.Tdv + ": ");
            v3.Anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Cilindradas del Motor: ");
            m3.Cilindradas = int.Parse(Console.ReadLine());

            //-----------------------------------------------------------------------
            Console.Write("Ingrese Diametro de Ruedas: ");
            r3.Diametro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Ruedas: ");
            Console.Write("\nAuto maximo 5 " + "\nMoto maximo 3" + "\nCamion maximo 10: ");
            r3.CantidadDeRuedas = int.Parse(Console.ReadLine());

            if (v3.Tdv == "auto" || v3.Tdv == "Auto")
            {
                do
                {


                    if (r3.CantidadDeRuedas > 5 || r3.CantidadDeRuedas < 4)
                    {
                        Console.Write("El " + v3.Tdv + " no puede tener más de 5 ruedas ni menos de 4.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r3.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }

                } while (r3.CantidadDeRuedas < 4 || r3.CantidadDeRuedas > 5);
            }


            if (v3.Tdv == "moto" || v3.Tdv == "Moto")
            {
                do
                {


                    if (r3.CantidadDeRuedas > 2)
                    {
                        Console.Write("El " + v3.Tdv + " no puede tener más de 3 ruedas ni menos de 2.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r3.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r3.CantidadDeRuedas < 2 || r3.CantidadDeRuedas > 3);
            }


            if (v3.Tdv == "camion" || v3.Tdv == "Camion")
            {
                do
                {
                    if (r3.CantidadDeRuedas > 10)
                    {
                        Console.Write("El " + v3.Tdv + " no puede tener más de 10 ruedas ni menos de 4.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r3.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r3.CantidadDeRuedas < 4 || r3.CantidadDeRuedas > 10);
            }

            //-------------------------------------------------------------------------------------------
            if (v3.Tdv == "auto" || v3.Tdv == "camion" || v3.Tdv == "Camion" || v3.Tdv == "Auto")
            {
                Console.Write("Ingresar cantidad de cambios de la caja: ");
                c3.CantidadCambios = int.Parse(Console.ReadLine());

                do
                {
                    if (c3.CantidadCambios > 6)
                    {
                        Console.Write("El automovil/camion no puede tener mas de 6 cambios (Incluida la reversa)");
                        Console.Write("\nIngrese nuevamente la cantidad de cambios: ");
                        c3.CantidadCambios = int.Parse(Console.ReadLine());
                    }
                } while (c3.CantidadCambios < 6);

                Console.Write("Ingrese tipo de transmision: Automatico/Manual: ");
                c3.Tipo = Console.ReadLine();
                if (!c3.Tipo.Equals("manual") && !c3.Tipo.Equals("automatico"))
                {
                    do
                    {
                        Console.Write("Unicamente la transmision puede ser Automatico o Manual.");
                        Console.Write("\nPor favor ingresar nuevamente el tipo de transmision del vehiculo: ");
                        c3.Tipo = Console.ReadLine();
                    } while (!c3.Tipo.Equals("manual") && !c3.Tipo.Equals("automatico"));

                }
            }
            Console.Write("   ");
            Console.Write("El Vehiculo 3 es un: " + v3.Tdv + "\nMarcar:  " + v3.Marca + "\nModelo: " + v3.Modelo + "\nAño: " + v3.Anio + "\nCon un motor de " + m3.Cilindradas + " Cilindaras" + "\ny Una caja de " + c3.CantidadCambios + " Cambios " + " " + c3.Tipo + "\nEquipado con " + r3.CantidadDeRuedas + " Ruedas, de un diametro de " + r3.Diametro + ".");
            Console.ReadKey();
            Console.Write("   ");
            Console.Write("   ");

            Vehiculo v4 = new Vehiculo();
            Motor m4 = new Motor();
            Ruedas r4 = new Ruedas();
            CajadeCambios c4 = new CajadeCambios();

            Console.Write("Ingrese Tipo de Vehiculo 1: Auto / Camion / Moto: ");
            v4.Tdv = Console.ReadLine();
            Console.Write("Ingrese Marcar del " + v1.Tdv + ": ");
            v4.Marca = Console.ReadLine();
            Console.Write("Ingrese Modelo del " + v1.Tdv + ": ");
            v4.Modelo = Console.ReadLine();
            Console.Write("Ingrese Año del " + v1.Tdv + ": ");
            v4.Anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Cilindradas del Motor: ");
            m4.Cilindradas = int.Parse(Console.ReadLine());

            //-----------------------------------------------------------------------
            Console.Write("Ingrese Diametro de Ruedas: ");
            r4.Diametro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Ruedas: ");
            Console.Write("\nAuto maximo 5 " + "\nMoto maximo 3" + "\nCamion maximo 10: ");
            r4.CantidadDeRuedas = int.Parse(Console.ReadLine());

            if (v4.Tdv == "auto" || v4.Tdv == "Auto")
            {
                do
                {


                    if (r4.CantidadDeRuedas > 5 || r4.CantidadDeRuedas < 4)
                    {
                        Console.Write("El " + v4.Tdv + " no puede tener más de 5 ruedas ni menos de 4.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r4.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }

                } while (r4.CantidadDeRuedas < 4 || r4.CantidadDeRuedas > 5);
            }


            if (v4.Tdv == "moto" || v4.Tdv == "Moto")
            {
                do
                {


                    if (r4.CantidadDeRuedas > 2)
                    {
                        Console.Write("El " + v4.Tdv + " no puede tener más de 3 ruedas ni menos de 2.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r4.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r4.CantidadDeRuedas < 2 || r4.CantidadDeRuedas > 3);
            }


            if (v4.Tdv == "camion" || v4.Tdv == "Camion")
            {
                do
                {
                    if (r4.CantidadDeRuedas > 10)
                    {
                        Console.Write("El " + v3.Tdv + " no puede tener más de 10 ruedas ni menos de 4.");
                        Console.Write("\nIngrese nuevamente la cantidad de ruedas: ");
                        r4.CantidadDeRuedas = int.Parse(Console.ReadLine());
                    }
                } while (r4.CantidadDeRuedas < 4 || r4.CantidadDeRuedas > 10);
            }

            //-------------------------------------------------------------------------------------------
            if (v4.Tdv == "auto" || v4.Tdv == "camion" || v4.Tdv == "Camion" || v4.Tdv == "Auto")
            {
                Console.Write("Ingresar cantidad de cambios de la caja: ");
                c4.CantidadCambios = int.Parse(Console.ReadLine());

                do
                {
                    if (c4.CantidadCambios > 6)
                    {
                        Console.Write("El automovil/camion no puede tener mas de 6 cambios (Incluida la reversa)");
                        Console.Write("\nIngrese nuevamente la cantidad de cambios: ");
                        c4.CantidadCambios = int.Parse(Console.ReadLine());
                    }
                } while (c4.CantidadCambios < 6);

                Console.Write("Ingrese tipo de transmision: Automatico/Manual: ");
                c3.Tipo = Console.ReadLine();
                if (!c4.Tipo.Equals("manual") && !c3.Tipo.Equals("automatico"))
                {
                    do
                    {
                        Console.Write("Unicamente la transmision puede ser Automatico o Manual.");
                        Console.Write("\nPor favor ingresar nuevamente el tipo de transmision del vehiculo: ");
                        c4.Tipo = Console.ReadLine();
                    } while (!c4.Tipo.Equals("manual") && !c4.Tipo.Equals("automatico"));

                }
            }
            Console.Write("   ");
            Console.Write("El Vehiculo 4 es un: " + v4.Tdv + "\nMarcar:  " + v4.Marca + "\nModelo: " + v4.Modelo + "\nAño: " + v4.Anio + "\nCon un motor de " + m4.Cilindradas + " Cilindaras" + "\ny Una caja de " + c4.CantidadCambios + " Cambios " + " " + c4.Tipo + "\nEquipado con " + r4.CantidadDeRuedas + " Ruedas, de un diametro de " + r4.Diametro + ".");
            Console.ReadKey();
            Console.Write("   ");
            Console.Write("   ");




        }
    }
}
