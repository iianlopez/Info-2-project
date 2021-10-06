using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightLib;
using System.Windows.Forms;


namespace SimulatorConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
            {

            }
            /*
            Console.WriteLine("Escribe el identificador");
            //   string nombre = Console.ReadLine();
            string identificador = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            
            double velocidad = 0;

            bool final = false;
            while (!final)
            { 
                try
                { 
                    velocidad = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(FormatException)
                { 
                    Console.WriteLine("Error de formato, introduzca una velocidad válida");
                }
            }

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");

            double ix = 0;
            double iy = 0;

            string linea;
            string[] trozos;
            final = false;
            while (!final)
            { 
                try
                {
                    linea = Console.ReadLine();
                    trozos = linea.Split(' ');
                    ix = Convert.ToDouble(trozos[0]);
                    iy = Convert.ToDouble(trozos[1]);
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una posición válida");
                }
            }
            
        
            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            
            double fx = 0;
            double fy = 0;

            final = false;
            while (!final)
            { 
                try
                {
                    linea = Console.ReadLine();
                    trozos = linea.Split(' ');
                    fx = Convert.ToDouble(trozos[0]);
                    fy = Convert.ToDouble(trozos[1]);
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una posición válida");
                }
            }

            double distanciaA = 0;
            Console.WriteLine("Escribe la distáncia de seguridad del avión");
            final = false;
            while (!final)
            { 
                try
                {
                    distanciaA = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una distáncia válida");
                }
            }

            FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad, distanciaA);

            Console.WriteLine("Escribe el segundo identificador");
            identificador = Console.ReadLine(); ;

            Console.WriteLine("Escribe la velocidad");
            
            velocidad = 0;

            final = false;
            while (!final)
            { 
                try
                { 
                    velocidad = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(FormatException)
                { 
                    Console.WriteLine("Error de formato, introduzca una velocidad válida");
                }
            }

            Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");

            ix = 0;
            iy = 0;
            final = false;
            while (!final)
            { 
                try
                {
                    linea = Console.ReadLine();
                    trozos = linea.Split(' ');
                    ix = Convert.ToDouble(trozos[0]);
                    iy = Convert.ToDouble(trozos[1]);
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una posición válida");
                }
            }
            
        
            Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
            
            fx = 0;
            fy = 0;

            final = false;
            while (!final)
            { 
                try
                {
                    linea = Console.ReadLine();
                    trozos = linea.Split(' ');
                    fx = Convert.ToDouble(trozos[0]);
                    fy = Convert.ToDouble(trozos[1]);
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una posición válida");
                }
            }

            double distanciaB = 0;
            Console.WriteLine("Escribe la distáncia de seguridad del avión");
            final = false;
            while (!final)
            { 
                try
                {
                    distanciaB = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca una distáncia válida");
                }
            }

            FlightPlan plan_b = new FlightPlan(identificador, ix, iy, fx, fy, velocidad, distanciaB);

            FlightPlanList lista = new FlightPlanList();
            lista.AddFlightPlan(plan_a);
            lista.AddFlightPlan(plan_b);

            Console.WriteLine("Cuantas veces quieres mover el vuelo?");

            double bucles = 0;
            final = false;
            while (!final)
            { 
                try
                {
                    bucles = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca un número de secuencias válido");
                }
            }

            Console.WriteLine("Cuantos segundos quieres que dure cada movimiento?");

            double seconds = 0;
            final = false;
            while (!final)
            { 
                try
                {
                    seconds = Convert.ToDouble(Console.ReadLine());
                    final = true;
                }
                catch(Exception)
                { 
                    Console.WriteLine("Error de formato, introduzca un número de segundos válido");
                }
            }

            int contador = 0;
            while (contador < bucles)
            {
                lista.Mover(seconds);
                lista.EscribirConsola();

                if (plan_a.conflicto(plan_b))
                { 
                    Console.WriteLine("=========== Han entrado en la zona de conflicto ===========");
                }

                contador ++;
                
            }

            Console.ReadLine();

            */
        }
    }
}
