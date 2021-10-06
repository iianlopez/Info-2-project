using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[10];
        int number = 0;

        //Metodos
        public int AddFlightPlan(FlightPlan f)
        {
            if (number < 10)
            {
                vector[number] = f;
                number++;
                return 0;
            }
            else
                return -1;
        }

        //Acceder a un FllightPlan
        public FlightPlan GetFlightPlan(int n)
        {
            if (n <= 10 || n > 0)
            {
                return vector[n];
            }
            else
                return null;
        }

        //Mover todos los FlightPlans de la lista a la vez
        public void Mover(double tiempo)
        {
            int i = 0;
            while (i<2)
            {
                vector[i].Mover(tiempo);
                i++;
            }

        }

        //Escribir por consola todos los FlightPlans de la lista
        public void EscribirConsola()
        {
            int i = 0;
            while (i < 2)
            {
                vector[i].EscribeConsola();
                i++;
            }
        }

    }
}
