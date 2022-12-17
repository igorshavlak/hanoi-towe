using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KYRSACH
{
    public class Tower
    {
        public Stack<int> h;
        private int nomer { get; set; }
        private int position;
        public void Add(int i)
        {
            h.Push(i);
        }
        public int Size()
        {
            return h.Count;
        }
        public Tower(int nomer, int postion)
        {
            this.nomer = nomer;
            h = new Stack<int>();
            this.position = postion;
        }
        public int GetNumber()
        {
            return this.nomer;
        }
        public int X
        {
            get { return 30 + (nomer - 1) * 200; }
        } 
        public int Y
        {
            get { return 70; }
        } 
        public void Draw(Graphics g)
        {
            int c = 0;
            for (int i = 0; i < h.Count(); i++)
            {
                int a = h.ElementAt(i);  
           
                DrawRectangle(GetColor(a),a + position, 300+c, a * 60, 40,g);
                c += 42;
          
            }
        }
        public void DrawRectangle(Brush brush,int xCenter, int yCenter, int width, int height, Graphics g)
        {
            int x = xCenter - width / 2;
            int y = yCenter - height / 2;
            g.FillRectangle(brush, x, y, width, height);
            
        }
        public Brush GetColor(int k)
        {

            switch (k)
            {
                case 1: return Brushes.Green;
                case 2: return Brushes.Yellow;
                case 3: return Brushes.Red;
                case 4: return Brushes.Purple;
                case 5: return Brushes.Aqua;
                case 6: return Brushes.Orange;
                case 7: return Brushes.Pink;
                case 8: return Brushes.Blue;
                default: throw new ArgumentException("Incorrect value");

            }


        }
       
        
    }
}
