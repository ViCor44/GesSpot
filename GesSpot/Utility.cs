﻿using System;
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
    public static class Utility
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
        public static void PlayPause()
        {
            // Janela do Spotify
            IntPtr hWnd = FindWindow("Chrome_WidgetWin_0", null);
            if (hWnd == IntPtr.Zero)
                return;
            uint pID;
            GetWindowThreadProcessId(hWnd, out pID);
            SendMessage(hWnd, WM_APPCOMMAND, hWnd, (IntPtr)APPCOMMAND_MEDIA_PLAY_PAUSE);
        }
        //--------------------------------------------------
        // Message box para fechar a aplicação
        public static bool CloseApliccation()
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer mesmo fechar a aplicação?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        //---------------------------------------------------
        // Conexão à base de dados
        public static SqlCeConnection DataBaseConnection()
        {
            string pastaBd = Application.StartupPath + @"\";
            string nomeBD = "anuncios.sdf";
            string source =  "Data Source=" + pastaBd + nomeBD;
            SqlCeConnection con = new SqlCeConnection(source);
            return con;
        }
        //------------------------------------------------
    }
}
