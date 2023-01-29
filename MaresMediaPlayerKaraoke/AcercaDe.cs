using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MaresMediaPlayerKaraoke
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath objDraw = new System.Drawing.Drawing2D.GraphicsPath();
            objDraw.AddEllipse(20, 20, 600, 250);
            btnAceptar.Focus();
            this.Region = new Region(objDraw); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}