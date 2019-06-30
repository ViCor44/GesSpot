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
    public partial class Prog : Form
    {
        bool ligado;
        public Prog()
        {
            InitializeComponent();
        }

        private void Prog_Load(object sender, EventArgs e)
        {

            GridDataView();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "HH:mm:ss";
        }
        
        public void GridDataView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            SqlCeConnection con = Utility.DataBaseConnection();
            con.Open();
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT Id, horario, buttonText, ligado FROM Schedule", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Schedule");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Schedule";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
           
            if (radioButton1.Checked)
                ligado = true;
            if (radioButton2.Checked)
                ligado = false;

            SqlCeConnection con = Utility.DataBaseConnection();
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand(@"INSERT INTO Schedule (horario, buttonText, buttonPath, ligado) 
            VALUES 
                (@horario, @buttonText, @buttonPath, @ligado)", con);
            cmd.Parameters.AddWithValue("horario", time);
            cmd.Parameters.AddWithValue("buttonText", comboBox1.Text);
            cmd.Parameters.AddWithValue("buttonPath", textBox2.Text);
            cmd.Parameters.AddWithValue("ligado", ligado);
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
        

        private void button4_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);
            SqlCeConnection con = Utility.DataBaseConnection();
            SqlCeCommand cmd = new SqlCeCommand();

            cmd.CommandText = "DELETE FROM Schedule  WHERE Id = " + textBox1.Text;           
            cmd.Parameters.AddWithValue("horario", time);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa Apagado na Base de Dados");
            else
                MessageBox.Show("Erro ao apagar o programa");
            con.Close();
            GridDataView();      
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(textBox1.Enabled)
                textBox1.Enabled = false;
            else
                textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string time = dateTimePicker1.Value.ToString();
            time = time.Substring(11);

            if (radioButton1.Checked)
                ligado = true;
            if (radioButton2.Checked)
                ligado = false;

            SqlCeConnection con = Utility.DataBaseConnection();
            SqlCeCommand cmd = new SqlCeCommand();

            cmd.CommandText = "UPDATE Schedule SET buttonText = @buttonText, horario = @horario, buttonPath = @buttonPath, ligado = @ligado Where  Id = " + textBox1.Text;

            cmd.Parameters.AddWithValue("horario", time);
            cmd.Parameters.AddWithValue("buttonText", comboBox1.Text);
            cmd.Parameters.AddWithValue("buttonPath", textBox2.Text);
            cmd.Parameters.AddWithValue("ligado", ligado);
            con.Open();
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (i != 0)
                MessageBox.Show("Programa alterado na Base de Dados");
            else
                MessageBox.Show("Erro ao alterar o programa");
            con.Close();
            GridDataView();
        }
    }
}
