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
using System.Data.SqlClient;

namespace GesSpot
{
    public partial class CriaAnuncio : Form
    {
        [System.ComponentModel.Browsable(false)]
        string color;
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

        private void label5_Click_1(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            
            if
             (cor.ShowDialog() == DialogResult.OK)
            {
                label5.BackColor = cor.Color;
                color = cor.Color.ToArgb().ToString("x");
                color = color.Substring(2, 6);
                color = "#" + color;
                label5.Text = color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ButtonSlideProperties (ButtonID, ButtonText, ButtonColor, ButtonPath) 
            VALUES 
                (@ButtonID, @ButtonText, @ButtonColor, @ButtonPath)", con);
            cmd.Parameters.AddWithValue("ButtonID", textBox3.Text);
            cmd.Parameters.AddWithValue("ButtonText", textBox1.Text);
            cmd.Parameters.AddWithValue("ButtonColor", label5.Text);
            cmd.Parameters.AddWithValue("ButtonPath", textBox2.Text);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Salvo na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o programa");
            con.Close();
        }        
    }
}
