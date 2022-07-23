using System;
using static System.Console;

namespace Poligones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Polygon polygon = new Polygon();
                polygon.Show();
                
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("How many corners does a polygon on the screen have?");
                int numCorn = int.Parse(Console.ReadLine());

                if (polygon.Corners != numCorn) //Если указано неправильное значение углов полигона выбрасывается пользовательское исключение
                {
                    Console.Clear();
                    throw new MyException(polygon.Corners);
                }

                Console.Clear();
                Console.WriteLine("You are right!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
