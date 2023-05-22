namespace Clases
{
    public class Jugada
    {
        private Boolean adivino;
        private int intentos;
        private int numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            numero = rnd.Next(maxNumero);
            intentos = 0;
        }


        public Boolean Adivino {
            get { 
                return adivino;
            }
            set {
                adivino = value;
            }
        }

        public int Intentos {
            get {
                return intentos;
            }
            set {
                intentos = value;
            }
        }

        public int Numero {
            get {
                return numero;
            }
            set {
                numero = value;
            }
        }

        public void Comparar()
        {
            int num;
            Console.Clear();
            intentos++;
            Console.WriteLine("Intento numero: " + intentos);
            Console.Write("Ingrese el numero que piensa que es: ");
            num = int.Parse(Console.ReadLine());
            if (num == numero)
            {
                adivino = true;
                Console.WriteLine("Felicitaciones adivino el numero "+numero);
            } else if (num > numero)
            {
                Console.WriteLine("El numero es menor que "+num);
            } else if (num < numero)
            {
                Console.WriteLine("El numero es mayor que " + num);
            }
            Console.ReadKey();
        }
    }
}