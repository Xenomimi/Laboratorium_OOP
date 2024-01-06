using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Rysuje circle x = {X} y = {Y} Height = {Height} Width = {Width}");
        }
    }
}
