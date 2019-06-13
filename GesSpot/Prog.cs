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
    public partial class Prog : Form
    {
        public Prog()
        {
            InitializeComponent();
        }

        private void Prog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gesSpotDataSet9.ButtonAnuncioProperties' table. You can move, or remove it, as needed.
            this.buttonAnuncioPropertiesTableAdapter2.Fill(this.gesSpotDataSet9.ButtonAnuncioProperties);
            // TODO: This line of code loads data into the 'gesSpotDataSet8.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.gesSpotDataSet8.Schedule);
            GridDataView();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }
        
        public void GridDataView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT horario, buttonText FROM Schedule", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ButtonAnuncioProperties");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ButtonAnuncioProperties";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Schedule (horario, buttonText, buttonPath) 
            VALUES 
                (@horario, @buttonText, @buttonPath)", con);
            cmd.Parameters.AddWithValue("horario", time);
            cmd.Parameters.AddWithValue("buttonText", comboBox1.Text);
            cmd.Parameters.AddWithValue("buttonPath", textBox2.Text);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Salvo na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o programa");
            con.Close();
            GridDataView();

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

        /*private void button3_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Schedule SET horario = @horario, buttonText = @buttonText, buttonPath = @buttonPath WHERE horario = @horario" ;
            //cmd.Parameters.AddWithValue("ButtonID", textBox3.Text);
            cmd.Parameters.AddWithValue("ButtonText", comboBox1.Text);            
            cmd.Parameters.AddWithValue("ButtonPath", textBox2.Text);
            cmd.Parameters.AddWithValue("horario", time);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Alterado na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o anuncio");
            con.Close();
            GridDataView();
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Schedule  WHERE horario = @horario";           
            cmd.Parameters.AddWithValue("horario", time);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Alterado na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o anuncio");
            con.Close();
            GridDataView();      
        }
    }
}
