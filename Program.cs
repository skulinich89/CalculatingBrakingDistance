using System;

namespace CalculatingBrakingDistance
{
    class Program
    {
        public static double Dist(double v, double mu)
        {
            double vconv;
            vconv = v / 3.6;
            return (vconv * 1) + vconv * vconv / (2 * mu * 9.81);
        }
        public static double Speed(double d, double mu)
        {
            double v;
            v = (-2 * mu * 9.81 + Math.Sqrt(Math.Pow(2 * mu * 9.81, 2) + 4 * d * 2 * mu * 9.81)) / 2;
            return v * 3.6;
        }
        static void Main(string[] args)
        {
            double dist_calc=0, speed_calc = 0, coefficient_of_friction = 0;
            try
            {

                Console.WriteLine("Enter braking distance(metrs) to calculating speed");
                dist_calc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter speed(km/h) to calculating braking distance");
                speed_calc = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coefficient of friction to calculating braking distance and speed");
                coefficient_of_friction = Convert.ToDouble(Console.ReadLine());

            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OverflowException");
            }
            Console.WriteLine("Distance: " + Dist(speed_calc, coefficient_of_friction));
            Console.WriteLine("Speed: " + Speed(dist_calc, coefficient_of_friction));
            Console.ReadKey();
        }
    }
}
