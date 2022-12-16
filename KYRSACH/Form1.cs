using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYRSACH
{
    public partial class Form1 : Form
    {
        Tower[] c;
        Graphics g;
        string moves;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            
            g.FillRectangle(Brushes.Black, 100, 100, 20, 400);
            g.FillRectangle(Brushes.Black, 300, 100, 20, 400);
            g.FillRectangle(Brushes.Black, 500, 100, 20, 400);
            c = new Tower[3];
            c[0] = new Tower(1,0);
            c[1] = new Tower(2,200);
            c[2] = new Tower(3,400);
            c[0].Add(3);
            c[0].Add(2);
            c[0].Add(1);
            c[0].Draw(g);


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
            AlgorithmHanoi(c[0].Size(), c[0].h, c[2].h, c[1].h);

        }
        private void AlgorithmHanoi(int n, Stack<int> from, Stack<int> to, Stack<int> help)
        {
            if (n > 0)
            {
                AlgorithmHanoi(n - 1, from, help, to);
                Move(n, from, to);
                AlgorithmHanoi(n - 1, help, to, from);
            }
        }
        private void Move(int ringSize, Stack<int> from, Stack<int> to)
        {
            
            //Console.WriteLine(" берем диск " + ringSize + " из " + from + " в " + to);

            //int indexOfRingSize = Array.IndexOf(from, ringSize);
            //int temp = from[indexOfRingSize];
            //from[indexOfRingSize] = 0;
            //moves = @" берем диск " + ringSize +  " из " + from. +  "в"  + to + \n";
            int k = from.Pop();
            to.Push(k);
            g.Clear(Color.White);
            c[0].Draw(g);
            c[1].Draw(g);
            c[2].Draw(g);
            Thread.Sleep(3000);
          
            //to[Array.LastIndexOf(to, 0)] = temp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }

}
