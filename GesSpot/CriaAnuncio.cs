using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesSpot
{
    public partial class CriaAnuncio : Form
    {
        [System.ComponentModel.Browsable(false)]
        public System.Windows.Forms.DialogResult DialogResult { get; set; }

        public CriaAnuncio()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();            

            if
             (cor.ShowDialog() == DialogResult.OK)
            {
                label5.BackColor = cor.Color;
            }
        }
    }
}
