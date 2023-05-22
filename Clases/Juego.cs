using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Juego
    {
        private int? record;

        public void ComenzarJuego()
        {
            int opcion = 10;
            /*llamado desde el main de la aplicación.Se debe encargar de mostrar mensajes al usuario, permitir realizar otra partida, llevar un control de record de menor cantidad de intentos para un acierto, etc.*/
            do
            {
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("1) Realizar otra partida");
                Console.WriteLine("2) Mostrar record de cantidad de intentos");
                Console.WriteLine("0) Salir");
                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese el numero maximo con el que desea jugar: ");
                        int numero = int.Parse(Console.ReadLine());
                        Jugada jugada = new Jugada(numero);
                        while (!jugada.Adivino)
                        {
                            jugada.Comparar();
                        }
                        if (jugada.Intentos < record || record == null)
                        {
                            record = jugada.Intentos;
                        } 
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("El record de intentos es: " + record);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcion != 0);
            
        }

        private void CompararRecord()
        {
            throw new System.NotImplementedException();
        }

        private void Continuar()
        {
            throw new System.NotImplementedException();
        }

        private void PreguntarMaximo()
        {
            throw new System.NotImplementedException();
        }

        private void PreguntarNumero()
        {
            throw new System.NotImplementedException();
        }
    }
}