using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafik_lambası_animasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac >=0 && sayac <= 40)
                this.listBox1.BackColor = Color.Red;
           
            if(sayac >=41 && sayac <= 55)
                this.listBox1.BackColor = Color.Yellow;
            
            if (sayac > 55)
                this.listBox1.BackColor = Color.Green;
            
            if (sayac > 70)
                sayac = 0;
        }
    }
}
