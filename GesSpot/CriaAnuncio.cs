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
            string tipo = "";
            if (radioButton1.Checked == true)
                tipo = "Slide";
            if (radioButton2.Checked == true)
                tipo = "Show";
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ButtonAnuncioProperties (ButtonText, ButtonColor, ButtonPath, tipo, ButtonID) 
            VALUES 
                (@ButtonText, @ButtonColor, @ButtonPath, @tipo, @ButtonID)", con);
            cmd.Parameters.AddWithValue("ButtonID", textBox3.Text);
            cmd.Parameters.AddWithValue("ButtonText", textBox1.Text);
            cmd.Parameters.AddWithValue("ButtonColor", label5.Text);
            cmd.Parameters.AddWithValue("ButtonPath", textBox2.Text);
            cmd.Parameters.AddWithValue("tipo", tipo);            
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Anuncio Salvo na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o anuncio");
            con.Close();
            GridDataView();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string tipo = "";           
            if (radioButton1.Checked == true)
                tipo = "Slide";
            if (radioButton2.Checked == true)
                tipo = "Show";
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE ButtonAnuncioProperties SET buttonText = @buttonText, buttonColor = @buttonColor, buttonPath = @buttonPath Where tipo = @tipo and buttonID = " + textBox3.Text;
                
            //cmd.Parameters.AddWithValue("ButtonID", textBox3.Text);
            cmd.Parameters.AddWithValue("ButtonText", textBox1.Text);
            cmd.Parameters.AddWithValue("ButtonColor", label5.Text);
            cmd.Parameters.AddWithValue("ButtonPath", textBox2.Text);
            cmd.Parameters.AddWithValue("tipo", tipo);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Anuncio Alterado na Base de Dados");
            else
                MessageBox.Show("Erro ao alterar o anuncio");
            con.Close();
            GridDataView();
        }

        private void CriaAnuncio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gesSpotDataSet12.ButtonAnuncioProperties' table. You can move, or remove it, as needed.
            this.buttonAnuncioPropertiesTableAdapter2.Fill(this.gesSpotDataSet12.ButtonAnuncioProperties);
            // TODO: This line of code loads data into the 'gesSpotDataSet11.ButtonAnuncioProperties' table. You can move, or remove it, as needed.
            this.buttonAnuncioPropertiesTableAdapter1.Fill(this.gesSpotDataSet11.ButtonAnuncioProperties);
            // TODO: This line of code loads data into the 'gesSpotDataSet10.ButtonAnuncioProperties' table. You can move, or remove it, as needed.
            this.buttonAnuncioPropertiesTableAdapter.Fill(this.gesSpotDataSet10.ButtonAnuncioProperties);
            GridDataView();
        }

        public void GridDataView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ButtonID, buttonText, tipo FROM ButtonAnuncioProperties", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ButtonAnuncioProperties");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ButtonAnuncioProperties";
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (radioButton1.Checked == true)
                tipo = "Slide";
            if (radioButton2.Checked == true)
                tipo = "Show";
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM ButtonAnuncioProperties WHERE tipo = @tipo AND buttonID = " + textBox3.Text;
            
            cmd.Parameters.AddWithValue("tipo", tipo);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Anuncio Apagado na Base de Dados");
            else
                MessageBox.Show("Erro ao apagar o anuncio");
            con.Close();
            GridDataView();
        }
    }
}
