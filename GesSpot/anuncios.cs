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
            SqlConnection con = Utility.DataBaseConnection();            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM ButtonAnuncioProperties WHERE tipo = 'Slide'", con);
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
                    case "6":
                        button6.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button6.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button6.Tag = path;
                        button6.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "7":
                        button7.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button7.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button7.Tag = path;
                        button7.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "8":
                        button8.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button8.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button8.Tag = path;
                        button8.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "9":
                        button9.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button9.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button9.Tag = path;
                        button9.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "10":
                        button10.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button10.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button10.Tag = path;
                        button10.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "11":
                        button11.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button11.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button11.Tag = path;
                        button11.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "12":
                        button12.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button12.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button12.Tag = path;
                        button12.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "13":
                        button13.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button13.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button13.Tag = path;
                        button13.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "14":
                        button14.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button14.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button14.Tag = path;
                        button14.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "15":
                        button15.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button15.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button15.Tag = path;
                        button15.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "16":
                        button16.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button16.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button16.Tag = path;
                        button16.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "17":
                        button17.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button17.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button17.Tag = path;
                        button17.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "18":
                        button18.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button18.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button18.Tag = path;
                        button18.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "19":
                        button19.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button19.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button19.Tag = path;
                        button19.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "20":
                        button20.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button20.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button20.Tag = path;
                        button20.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "21":
                        button21.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button21.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button21.Tag = path;
                        button21.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "22":
                        button22.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button22.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button22.Tag = path;
                        button22.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "23":
                        button23.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button23.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button23.Tag = path;
                        button23.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "24":
                        button24.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button24.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button24.Tag = path;
                        button24.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "25":
                        button25.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button25.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button25.Tag = path;
                        button25.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "26":
                        button26.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button26.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button26.Tag = path;
                        button26.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "27":
                        button27.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button27.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button27.Tag = path;
                        button27.Click += new System.EventHandler(this.button_Clicked);
                        break;
                    case "28":
                        button28.Text = row["buttonID"].ToString() + " - " + row["buttonText"].ToString();
                        myColor = row["buttonColor"].ToString();
                        button28.BackColor = System.Drawing.ColorTranslator.FromHtml(myColor);
                        path = row["buttonPath"].ToString();
                        button28.Tag = path;
                        button28.Click += new System.EventHandler(this.button_Clicked);
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

        public void PlaySpot(string Url)
        {
            Utility.PlayPause();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
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
            wplayer.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);

        }

        private void Player_PlayStateChange(int NewState)
        {
            if (NewState == 1)
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