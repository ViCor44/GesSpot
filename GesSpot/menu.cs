using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Runtime.InteropServices;
using System.IO;

namespace GesSpot
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anuncios frm = new Anuncios();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriaAnuncio frm = new CriaAnuncio();
            frm.ShowDialog();
        }        
        /*-------------------Fechar Aplicação---------------------*/
        private void button4_Click(object sender, EventArgs e)
        {
            if (Utility.CloseApliccation())
                System.Environment.Exit(0);
        }

        private void Menu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!Utility.CloseApliccation())
                e.Cancel = true;            
        }
        /*--------------------------------------------------------*/
        /*--------------------------Clock-------------------------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = ": " + DateTime.Now.ToString("ss");
        }
        /*--------------------------------------------------------*/


    }
}
