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
    public partial class Anuncios : Form
    {
        
        
              

        

        public Anuncios()
        {
            InitializeComponent();

        }
        // Instancia os botões dos anuncios
        private void Form1_Load(object sender, EventArgs e)
        {
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GesSpot\GesSpot.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ButtonProperties", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string myColor;
            string path;
            foreach (DataRow row in dt.Rows)
            {                

                switch (row["buttonID"].ToString().ToLower())
                {
                    case "1":
                        button1.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button1.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button1.Tag = path;
                        button1.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "2":
                        button2.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button2.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button2.Tag = path;
                        button2.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "3":
                        button3.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button3.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button3.Tag = path;
                        button3.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "4":
                        button4.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button4.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button4.Tag = path;
                        button4.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "5":
                        button5.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button5.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button5.Tag = path;
                        button5.Click += new System.EventHandler(this.button_Clicked);
                        break;
                }                
            }
            // botões não instanciados ficam invisiveis
            foreach (Control b in Controls)
            {
                if (b is Button && String.IsNullOrEmpty(b.Text))
                {
                    b.Visible = false;
                }
            }            
        }

        /*----------------- Anuncios -----------------------------*/
        private void button_Clicked(object sender, EventArgs e)
        {
            string path;
            Button triggeredButton = (Button)sender;            
            path = (string)((Button)sender).Tag;
            PlaySpot(path);           
        }      

        public void PlaySpot(String Url)
        {
            Utility.PlayPause();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            wplayer.URL = Url;
            // Desliga todos os botoes
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
            }
            wplayer.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Utility.PlayPause();
                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = true;
                    }
                }
            }
        }
        /*----------------------------------------------*/
    }
}