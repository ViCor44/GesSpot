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
using System.Timers;

namespace GesSpot
{
    public partial class Menu : Form
    {
        string anuncio;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing;
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }    

        /*--------------------------Clock-------------------------*/
        public void timer1_Tick(object sender, EventArgs e)
        {
            bool onligado;
            label1.Text = DateTime.Now.ToString("HH:mm");
            label2.Text = ":" + DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToLongDateString();
            DateTime current = DateTime.Now;
            SqlCeConnection con = Utility.DataBaseConnection();
            SqlCeDataAdapter sda = new SqlCeDataAdapter("SELECT * FROM Schedule", con);
            SqlCeDataAdapter sdab = new SqlCeDataAdapter("SELECT * FROM AberturaFecho", con);
            DataTable dt = new DataTable();
            DataTable du = new DataTable();
            sda.Fill(dt);
            sdab.Fill(du);
            foreach (DataRow r in du.Rows)
            {
                DateTime myclosetime, fifteen, ten, five, myopentime;
                string closetime = r["fecho"].ToString();
                string opentime = r["abertura"].ToString();
                myclosetime = DateTime.Parse(closetime);
                myopentime = DateTime.Parse(opentime);
                fifteen = myclosetime.Add(new TimeSpan(0, -15, 0));
                ten = myclosetime.Add(new TimeSpan(0, -10, 0));
                five = myclosetime.Add(new TimeSpan(0, -5, 0));

                if (myopentime.Hour == current.Hour && myopentime.Minute == current.Minute && myopentime.Second == current.Second)
                {
                    Utility.PlayPause();
                }

                if (fifteen.Hour == current.Hour && fifteen.Minute == current.Minute && fifteen.Second == current.Second)
                {
                    anuncio = "15 Minutos para Fecho";
                    label4.Text = anuncio;
                    PlayProg(r["anuncio15"].ToString());
                }

                if (ten.Hour == current.Hour && ten.Minute == current.Minute && ten.Second == current.Second)
                {
                    anuncio = "10 Minutos para Fecho";
                    label4.Text = anuncio;
                    PlayProg(r["anuncio10"].ToString());
                }

                if (five.Hour == current.Hour && five.Minute == current.Minute && five.Second == current.Second)
                {
                    anuncio = "5 Minutos para Fecho";
                    label4.Text = anuncio;
                    PlayProg(r["anuncio5"].ToString());
                }

                if (myclosetime.Hour == current.Hour && myclosetime.Minute == current.Minute && myclosetime.Second == current.Second)
                {
                    anuncio = "Fecho";
                    label4.Text = anuncio;
                    PlayProg(r["anuncioFecho"].ToString());                    
                }
                string abertura = r["abertura"].ToString();
                abertura = abertura.Substring(11);
                string fecho = r["fecho"].ToString();
                fecho = fecho.Substring(11);
                label8.Text = abertura;
                label9.Text = fecho;
                progressBar1.Value = (int)wplayer.controls.currentPosition;
            }
                

            foreach (DataRow row in dt.Rows)
            {                
                onligado = Convert.ToBoolean(row["ligado"].ToString()); 
                if (onligado)
                {
                    DateTime myTime;
                    string anTime = row["horario"].ToString();
                    string ficheiro = row["buttonPath"].ToString();
                    anuncio = row["buttonText"].ToString();
                    myTime = DateTime.Parse(anTime);
                    if (myTime.Hour == current.Hour && myTime.Minute == current.Minute && myTime.Second == current.Second)
                    {
                        label4.Text = anuncio;
                        PlayProg(ficheiro);
                    }
                }
            }
        }
        /*--------------------------------------------------------*/

        public void PlayProg(string Url)
        {
            
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_Player_PlayStateChange);
            wplayer.URL = Url;
            wplayer.controls.play();                       
        }

        private void wplayer_Player_PlayStateChange(int NewState)
        {
            if (NewState == 3)
            {
                Utility.PlayPause();                
                label10.Visible = true;
                label4.Visible = true;
                double dur = wplayer.currentMedia.duration;
                progressBar1.Visible = true;
                progressBar1.Maximum = (int)dur;
                return;
            }
            if (NewState == 8)            
            {

                label10.Visible = false;
                label4.Visible = false;
                progressBar1.Visible = false;
                if (anuncio == "Fecho")
                    return;
                Utility.PlayPause();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Prog frm = new Prog();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Shows frm = new Shows();
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

        private void button7_Click(object sender, EventArgs e)
        {
            AberturaFecho frm = new AberturaFecho();
            frm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }        
    }
}
