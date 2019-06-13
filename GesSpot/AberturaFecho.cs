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
    public partial class AberturaFecho : Form
    {
        public AberturaFecho()
        {
            InitializeComponent();
        }

        private void AberturaFecho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gesSpotDataSet20.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter5.Fill(this.gesSpotDataSet20.AberturaFecho);
            // TODO: This line of code loads data into the 'gesSpotDataSet19.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter4.Fill(this.gesSpotDataSet19.AberturaFecho);
            // TODO: This line of code loads data into the 'gesSpotDataSet18.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter3.Fill(this.gesSpotDataSet18.AberturaFecho);
            // TODO: This line of code loads data into the 'gesSpotDataSet17.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter2.Fill(this.gesSpotDataSet17.AberturaFecho);
            // TODO: This line of code loads data into the 'gesSpotDataSet16.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter1.Fill(this.gesSpotDataSet16.AberturaFecho);
            // TODO: This line of code loads data into the 'gesSpotDataSet13.AberturaFecho' table. You can move, or remove it, as needed.
            this.aberturaFechoTableAdapter.Fill(this.gesSpotDataSet13.AberturaFecho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abertura = dateTimePicker1.Value.ToString();
            abertura = abertura.Substring(11);
            string fecho = dateTimePicker2.Value.ToString();
            fecho = fecho.Substring(11);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE AberturaFecho SET abertura = @abertura, fecho = @fecho, anuncio15 = @anuncio15, anuncio10 = @anuncio10, anuncio5 = @anuncio5, anuncioFecho = @anuncioFecho WHERE Id = 1";
            //cmd.Parameters.AddWithValue("ButtonID", textBox3.Text);
            cmd.Parameters.AddWithValue("abertura", abertura);
            cmd.Parameters.AddWithValue("fecho", fecho);
            cmd.Parameters.AddWithValue("anuncio15", comboBox1.Text);
            cmd.Parameters.AddWithValue("anuncio10", comboBox2.Text);
            cmd.Parameters.AddWithValue("anuncio5", comboBox3.Text);
            cmd.Parameters.AddWithValue("anuncioFecho", comboBox4.Text);
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

        public void GridDataView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 15);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT abertura, fecho FROM AberturaFecho", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "AberturaFecho");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "AberturaFecho";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = dialog.FileName;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBox2.Text = dialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBox3.Text = dialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBox4.Text = dialog.FileName;
            }
        }
    }
}
