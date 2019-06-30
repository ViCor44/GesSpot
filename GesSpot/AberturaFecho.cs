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
using System.Data.SqlServerCe;
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
            GridDataView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abertura = dateTimePicker1.Value.ToString();
            abertura = abertura.Substring(11);
            string fecho = dateTimePicker2.Value.ToString();
            fecho = fecho.Substring(11);
            SqlCeConnection con = Utility.DataBaseConnection();
            SqlCeCommand cmd = new SqlCeCommand();

            cmd.CommandText = "UPDATE AberturaFecho SET abertura = @abertura, fecho = @fecho, anuncio15 = @anuncio15, anuncio10 = @anuncio10, anuncio5 = @anuncio5, anuncioFecho = @anuncioFecho WHERE Id = 1";            
            cmd.Parameters.AddWithValue("abertura", abertura);
            cmd.Parameters.AddWithValue("fecho", fecho);
            cmd.Parameters.AddWithValue("anuncio15", textBox1.Text);
            cmd.Parameters.AddWithValue("anuncio10", textBox2.Text);
            cmd.Parameters.AddWithValue("anuncio5", textBox3.Text);
            cmd.Parameters.AddWithValue("anuncioFecho", textBox4.Text);
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
            SqlCeConnection con = Utility.DataBaseConnection();
            con.Open();
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT abertura, fecho FROM AberturaFecho", con);
            SqlCeDataAdapter du = new SqlCeDataAdapter("SELECT * FROM AberturaFecho", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "AberturaFecho");
            du.Fill(dt);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "AberturaFecho";
            foreach (DataRow r in dt.Rows)
            {
                textBox1.Text = r["anuncio15"].ToString();
                textBox2.Text = r["anuncio10"].ToString();
                textBox3.Text = r["anuncio5"].ToString();
                textBox4.Text = r["anuncioFecho"].ToString();
            }
                con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dialog.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Media Files|*.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = dialog.FileName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
