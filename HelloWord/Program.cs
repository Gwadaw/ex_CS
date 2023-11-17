using System;

namespace Cars
{
    class Car2
    {
        public bool isRun = false;
        public int speed = 0;

        public void Start()
        {
            if (!isRun)
            {
                Console.WriteLine("La voiture démarre.");
                isRun = true;
            }
            else
            {
                Console.WriteLine("La voiture est déjà en marche.");
            }
        }

        public void Accelerate(int kmh)
        {
            if (!isRun)
            {
                Console.WriteLine("La voiture n'est pas en marche. Démarrez d'abord la voiture.");
                return;
            }

            if (speed + kmh <= 250)
            {
                speed += kmh;
                Console.WriteLine($"La voiture accélère de {kmh} km/h. Vitesse actuelle : {speed} km/h");
            }
            else
            {
                Console.WriteLine("La vitesse maximale de 250 km/h est atteinte. Impossible d'accélérer davantage.");
            }
        }

        public void Brake()
        {
            if (isRun && speed > 0)
            {
                Console.WriteLine("La voiture freine.");
                speed -= 10;
                Console.WriteLine($"Vitesse actuelle: {speed} km/h.");
            }
            else if (isRun && speed == 0)
            {
                Console.WriteLine("La voiture est déjà à l'arrêt.");
            }
            else
            {
                Console.WriteLine("La voiture n'est pas en marche. Démarrez d'abord la voiture.");
            }
        }

        public void Stop()
        {
            if (isRun)
            {
                Console.WriteLine("La voiture s'arrête.");
                while (speed > 0)
                {
                    speed -= 10;
                    Console.WriteLine($"La voiture continue de freiner et sa vitesse est de {speed} km/h.");
                }
                speed = 0;
                isRun = false;
            }
            else
            {
                Console.WriteLine("La voiture n'est pas en marche.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wheel a = new Wheel(15);
            Door b = new Door(1, 80);
            Window c = new Window(20);
            Engine d = new Engine(200);
            Color e = new Color("red");
            Horsepower f = new Horsepower(130);


            Console.WriteLine($"Wheel size: {a.size}");
            Console.WriteLine($"Door height: {b.height}, weight: {b.weigth}");
            Console.WriteLine($"Window weight: {c.weigth}");
            Console.WriteLine($"Engine weight: {d.weigth}");
            Console.WriteLine($"Car color: {e.color}");
            Console.WriteLine($"Horsepower: {f.nbhorse}");

            Car2 g = new Car2();

            while (true)
            {
                Console.WriteLine("Appuyez sur A pour démarrer, B pour accélérer, C pour freiner, D pour s'arrêter, ou Q pour quitter.");
                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.A:
                        g.Start();
                        break;
                    case ConsoleKey.B:
                        g.Accelerate(20);
                        break;
                    case ConsoleKey.C:
                        g.Brake();
                        break;
                    case ConsoleKey.D:
                        g.Stop();
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Touche non reconnue.");
                        break;
                }
            }
        }
    }
}

