using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
                g.FillRectangle(Brushes.Green,10 + a*10 + position, 460-c , 200 - a * 20, 40);
                c += 42;
          
            }
        }
    }
}
