using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MaresMediaPlayerKaraoke
{
    public partial class Entrada : Form
    {
                public Entrada()
        {
            InitializeComponent();
        }


        private void Entrada_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath objDraw = new System.Drawing.Drawing2D.GraphicsPath();            
            objDraw.AddEllipse(30, 30,200 ,200);
            this.Region = new Region(objDraw); 
        }

        int segundos = 0;
        private void tmEntrada_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos==20)
            {
                this.Visible = false;
                Form1 Reproductor = new Form1();
                Reproductor.ShowDialog();                
            }
        }

        private void Entrada_Activated(object sender, EventArgs e)
        {
            
        }
    }
}