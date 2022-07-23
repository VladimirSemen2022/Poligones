using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligones
{
    internal class Polygon
    {
        public Point[] point;
        public int Corners;

        public Polygon() 
        {
            Random rnd = new Random();
            Corners = rnd.Next(3, 10);
            this.point = new Point[Corners+1];
            int x, y;
            for (int i = 0; i < Corners; i++)
            {
                x = rnd.Next(5, 100);
                y = rnd.Next(5, 30);
                this.point[i] = new Point (x, y);
            }
            this.point[Corners] = new Point(this.point[0].X, this.point[0].Y);
        }

        public Polygon(int corners)
        {
            Random rnd = new Random();
            Corners = corners;
            this.point = new Point[Corners+1];
            int x, y;
            for (int i = 0; i < Corners; i++)
            {
                x = rnd.Next(5, 100);
                y = rnd.Next(30, 100);
                this.point[i] = new Point(x, y);
            }
            this.point[Corners] = new Point(this.point[0].X, this.point[0].Y);
        }

        public void AddCornerCoordinaty(int pos, int x, int y)
        {
            this.point[pos - 1] = new Point(x, y);
            if (pos==1)
                this.point[this.Corners] = new Point(x, y);
        }

        //void Drow(Point point1, Point point2)
        //{
        //    float deltaX = (point2- point[corner]) / (Y1 - Y0);
        //    for (int i = Y0; i <= Y1; i++)
        //    {

        //    }

        //}

        public void Show()
        {
            Console.Clear();
            double deltaXY,  deltaYX, deltaX, deltaY;
            for (int i = 0; i < this.Corners; i++)
            {
                deltaX = (this.point[i + 1].X - this.point[i].X);
                deltaY = (this.point[i + 1].Y - this.point[i].Y);
                if (deltaY == 0)
                    deltaXY = 0;
                else
                    deltaXY = deltaX / deltaY;
                if (deltaX == 0)
                    deltaYX = 0;
                else
                    deltaYX = deltaY / deltaX;
                //
                if (deltaY > 0)
                {
                    double pos = this.point[i].X - deltaXY;
                    for (int j = this.point[i].Y; j <= this.point[i + 1].Y; j++)
                    {
                        pos += deltaXY;
                        Console.SetCursorPosition(Convert.ToInt32(pos), j);
                        Console.Write('*');
                    }
                }
                else if (deltaY < 0)
                {
                    double pos = this.point[i].X + deltaXY;
                    for (int j = this.point[i].Y; j >= this.point[i+1].Y; j--)
                    {
                        pos -= deltaXY;
                        Console.SetCursorPosition(Convert.ToInt32(pos), j);
                        Console.Write('*');
                    }
                }
                else
                {
                    if (deltaX >= 0)
                    {
                        for (int j = this.point[i].X; j <= this.point[i + 1].X; j++)
                        {
                            Console.SetCursorPosition(j, this.point[i].Y);
                            Console.Write('*');
                        }
                    }
                    if (deltaX < 0)
                    {
                        for (int j = this.point[i].X; j >= this.point[i + 1].X; j--)
                        {
                            Console.SetCursorPosition(j, this.point[i].Y);
                            Console.Write('*');
                        }
                    }
                }
                    
            }
        }
    }
}
