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
namespace GesSpot
{
    public partial class Anuncios : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        private const int APPCOMMAND_MEDIA_PLAY_PAUSE = 0xE0000;
        private const int APPCOMMAND_MEDIA_NEXTTRACK = 0xB0000;
        private const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 0xC0000;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();

        // Pausa o Spotify
        public void PlayPause()
        {
            // Janela do Spotify
            IntPtr hWnd = FindWindow("Chrome_WidgetWin_0", null);
            if (hWnd == IntPtr.Zero)
                return;
            uint pID;
            GetWindowThreadProcessId(hWnd, out pID);
            SendMessage(hWnd, WM_APPCOMMAND, hWnd, (IntPtr)APPCOMMAND_MEDIA_PLAY_PAUSE);
        }

        public Anuncios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // ... If the directory doesn't exist, create it.
                if (!Directory.Exists(@"C:\GesSpot\"))
                {
                    Directory.CreateDirectory(@"C:\GesSpot\");
                }
            }
            catch (Exception)
            {
                // Fail silently.
            }
            string path = @"C:\GesSpot\Example.txt";
            ReadFile(path);
        }

        /* ----------------------Read Button Name ---------------*/
        public void ReadFile(string path)
        {
            int i = 0;
            List<string> lines = new List<string>();

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                lines = File.ReadAllLines(path).ToList();
            }
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Text = lines[i];
                    i++;
                    if (String.IsNullOrEmpty(b.Text))
                    {
                        b.Visible = false;
                    }
                }

            }
        }
        /*--------------------------------------------------------*/

        /*----------------- Anuncios -----------------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            PlaySpot(@"C:\Users\Vitor\Downloads\Relvado disponivel.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaySpot(@"C:\Users\Vitor\Downloads\Retoma de energia.mp3");
        }
        /*---------------------------------------------------------*/

        public void PlaySpot(String Url)
        {
            PlayPause();
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
                PlayPause();
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
    }
}