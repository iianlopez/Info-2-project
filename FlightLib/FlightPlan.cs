using System;
using System.Collections.Generic;
using System.Text;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition;
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;
        double DistanciaSeguridad;
        
        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad, double DistanciaSeguridad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = initialPosition;
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
            this.DistanciaSeguridad = DistanciaSeguridad;
        }

        // Metodos

        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad;  }


        public string GetIdentificator(FlightPlan airplane)
        {
            String airplaneName = airplane.id;
            return airplaneName;
        }
        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);
            if (hipotenusa > currentPosition.Distancia(nextPosition))
            {
                currentPosition = nextPosition;
            }
            else
            {
                currentPosition = finalPosition;
            }
        }

        public bool Destino()
        {
            if (finalPosition == currentPosition)
                return true;
            else
                return false;
        }
        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2},{1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (Destino())
            {
                Console.WriteLine("Ha llegado a su destino");
            }
            else
            {
                Console.WriteLine("No ha llegado a su destino");
            }
            Console.WriteLine("******************************");
        }

        public bool Conflicto(FlightPlan b)
        {
            bool conflicto = false;
            if (b.DistanciaSeguridad > this.currentPosition.Distancia(b.currentPosition))
                conflicto = true;
            return conflicto;
        }

        public Position GetPosition()
        {
            return currentPosition;
        }
        public Position GetFinalPosition()
        {
            return finalPosition;
        }
        public Position GetInitialPosition()
        {
            return initialPosition;
        }
        public double GetDistance()
        {
            return DistanciaSeguridad;
        }
        public void Restart()
        {
            this.currentPosition = initialPosition;
        }
            
    }
}
