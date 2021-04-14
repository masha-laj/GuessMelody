using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelodyWF
{
    public partial class FGame : Form
    {
        Random rnd = new Random();
        int musicDuration = Victorina.musicDuration;
        bool[] players = new bool[2];
        
        public FGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) GameEnd();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                axWindowsMediaPlayer1.URL = Victorina.list[n];
                Victorina.answer = axWindowsMediaPlayer1.URL;
                //axWindowsMediaPlayer1.Ctlcontrols.play(); - на случай если нет автовоспроизведения медиаплеера
                Victorina.list.RemoveAt(n);
                lbl_song_count.Text = Victorina.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void FGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void FGame_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            musicDuration = Victorina.musicDuration;
            lbl_song_count.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lbl_mus_dur.Text = musicDuration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lbl_mus_dur.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                GameEnd();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btn_contin_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        void GamePause()
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        void GamePlay()
        {
            timer1.Start();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        void GameEnd()
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void FGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled || axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying) return;
            if (players [0] == false && (e.KeyData == Keys.Q || e.KeyData == Keys.W || e.KeyData == Keys.E || e.KeyData == Keys.R))
            {
                GamePause();
                FMessage fm = new FMessage();
                fm.Owner = this;
                fm.lbl_message.Text = "Игрок 1";
                players[0] = true;
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lbl_counter1.Text = Convert.ToString(Convert.ToInt32(lbl_counter1.Text)+1);
                    MakeMusic();
                }
                GamePlay();
            }
            if (players[1] == false && (e.KeyData == Keys.P || e.KeyData == Keys.O || e.KeyData == Keys.I || e.KeyData == Keys.U))
            {
                GamePause();
                FMessage fm = new FMessage();
                fm.Owner = this;
                fm.lbl_message.Text = "Игрок 2";
                players[1] = true;
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lbl_counter2.Text = Convert.ToString(Convert.ToInt32(lbl_counter2.Text) + 1);
                    MakeMusic();
                }
                GamePlay();
            }
        }

        private void axWindowsMediaPlayer1_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (axWindowsMediaPlayer1.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    axWindowsMediaPlayer1.Ctlcontrols.currentPosition = rnd.Next(0, (int)axWindowsMediaPlayer1.currentMedia.duration / 2);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_counter1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right) (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }
    }
}
