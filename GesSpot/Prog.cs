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
            // TODO: This line of code loads data into the 'gesSpotDataSet2.ProgHor' table. You can move, or remove it, as needed.
            this.progHorTableAdapter.Fill(this.gesSpotDataSet2.ProgHor);
            // TODO: This line of code loads data into the 'gesSpotDataSet1.ButtonProperties' table. You can move, or remove it, as needed.
            this.buttonPropertiesTableAdapter1.Fill(this.gesSpotDataSet1.ButtonProperties);
            // TODO: This line of code loads data into the 'gesSpotDataSet.ButtonProperties' table. You can move, or remove it, as needed.
            this.buttonPropertiesTableAdapter.Fill(this.gesSpotDataSet.ButtonProperties);
            GridDataView();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO ProgHor (horario, Anuncio) 
            VALUES 
                (@horario, @Anuncio)", con);
            cmd.Parameters.AddWithValue("horario", time);
            cmd.Parameters.AddWithValue("Anuncio", comboBox1.Text);
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Salvo na Base de Dados");
            else
                MessageBox.Show("Erro ao salvar o programa");
            con.Close();
            GridDataView();

        }
        public void GridDataView()
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT horario, Anuncio FROM ProgHor", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProgHor");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ProgHor";
            con.Close();
        }

    }
}
