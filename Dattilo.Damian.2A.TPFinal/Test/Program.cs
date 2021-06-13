using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AireAcondicionado ac1 = new AireAcondicionado(1234, EficienciaEnergetica.A, ETipo.FrioCalor);
            AireAcondicionado ac2 = new AireAcondicionado(5555, EficienciaEnergetica.D, ETipo.Calor);
            AireAcondicionado ac3 = new AireAcondicionado(7777, EficienciaEnergetica.B, ETipo.Calor);
            AireAcondicionado ac4 = new AireAcondicionado(8888, EficienciaEnergetica.D, ETipo.Frio);
            AireAcondicionado ac5 = new AireAcondicionado(8778, EficienciaEnergetica.D, ETipo.Frio);
            AireAcondicionado ac6 = new AireAcondicionado(8978, EficienciaEnergetica.D, ETipo.Deshumidificador);


            Microondas m1 = new Microondas(2222, EficienciaEnergetica.B, ETamanio.Grande);
            Microondas m2 = new Microondas(3333, EficienciaEnergetica.C, ETamanio.Chico);
            Microondas m3 = new Microondas(4215, EficienciaEnergetica.A, ETamanio.Mediano);
            Microondas m4 = new Microondas(4515, EficienciaEnergetica.A, ETamanio.Mediano);


            ControlSeguridad<AireAcondicionado> ca = new ControlSeguridad<AireAcondicionado>(3);
            ControlSeguridad<Microondas> cm = new ControlSeguridad<Microondas>(2);


            try
            {
                ca.Agregar(ac1);   // SE AGREGAN LOS OBJETOS A LA LISTA
                ca.Remover(ac6);
                ca.Agregar(ac2);
                ca.Agregar(ac3);
                ca.Agregar(ac4);
                ca.Agregar(ac5);
                ca.Agregar(ac6);

                cm.Agregar(m1);
                cm.Agregar(m2);
                cm.Agregar(m2);
                cm.Remover(m1);
                cm.Agregar(m3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(ca);  //SE MUESTRAN LAS LISTAS POR PANTALLA
            Console.WriteLine(cm);
            
            try
            {
                using (StreamWriter sw = new StreamWriter("text2.txt"))  // SE GRABA EN EL ARCHIVO DE TEXTO
                {
                    sw.WriteLine("Archivo de texto\n");
                    sw.WriteLine(ca);
                    sw.WriteLine(cm);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (StreamReader sr = new StreamReader("text2.txt"))  // SE LEE DESDE EL ARCHIVO DE TEXTO Y SE MUESTRA POR PANTALLA
                {
                    String linea;
                    while((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
