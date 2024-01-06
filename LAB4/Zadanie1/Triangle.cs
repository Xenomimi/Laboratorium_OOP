using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Rysuje triangle x = {X} y = {Y} Height = {Height} Width = {Width}");
        }
    }
}
