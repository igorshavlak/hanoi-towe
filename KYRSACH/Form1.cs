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
            listMoves.Items.Clear();
            
            c = new Tower[3];
            c[0] = new Tower(1,110);
            c[1] = new Tower(2,310);
            c[2] = new Tower(3,510);
      
            c[0].Add(4);
            c[0].Add(3);
            c[0].Add(2);
            c[0].Add(1);
            GenerateField();
        }
        private void TowerFilling()
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
           
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            AlgorithmHanoi(c[0].Size(), c[0], c[2], c[1]);

        }
        private void AlgorithmHanoi(int n, Tower from, Tower to, Tower help)
        {
            if (n > 0)
            {
                AlgorithmHanoi(n - 1, from, help, to);
                moves += " take disk " + n + " from " + from.GetNumber() + " to " + to.GetNumber() + "\n";
                string line = string.Format("Move disk {0} from {1} to {2}", n, from.GetNumber(), to.GetNumber());
                listMoves.Items.Add(line);
                Move(n, from, to);
                AlgorithmHanoi(n - 1, help, to, from);
            }
        }
        private void Move(int ringSize, Tower from, Tower to)
        {
            int k = from.h.Pop();
            to.h.Push(k);
            Thread.Sleep(200);
          
            GenerateField();
        }
        private void GenerateField()
        {
            g.Clear(Color.White);
            g.FillRectangle(Brushes.Black, 100, 100, 20, 400);
            g.FillRectangle(Brushes.Black, 300, 100, 20, 400);
            g.FillRectangle(Brushes.Black, 500, 100, 20, 400);
            c[0].Draw(g);
            c[1].Draw(g);
            c[2].Draw(g);
        }

        private void DiskCount_ValueChanged(object sender, EventArgs e)
        {
            c[0].h.Clear();
            for(int i = (int)DiskCount.Value; i > 0; i--)
            {
                c[0].h.Push(i);
            }
            GenerateField();
        }

    
    }

}
