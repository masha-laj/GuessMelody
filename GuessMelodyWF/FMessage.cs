using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelodyWF
{
    public partial class FMessage : Form
    {
        int timeAnswer = 5;
        public FMessage()
        {
            InitializeComponent();
        }

        private void FMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = 5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lbl_timer.Text = timeAnswer.ToString();
            if(timeAnswer == 4)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\obratnyiy-otschet-na-ustroystve-27320.wav");
                sp.Play();
            }
            if (timeAnswer == 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\obratnyiy-otschet-na-ustroystve-27320.wav");
                sp.Stop();
                timer1.Stop();
                Close();
            }
        }

        private void FMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (timeAnswer <= 4 && timeAnswer >= 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\obratnyiy-otschet-na-ustroystve-27320.wav");
                sp.Stop();
                timer1.Stop();
                Close();
            }
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if (timeAnswer <= 4 && timeAnswer >= 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\obratnyiy-otschet-na-ustroystve-27320.wav");
                sp.Stop();
                timer1.Stop();
                Close();
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (timeAnswer <= 4 && timeAnswer >= 0)
            {
                SoundPlayer sp = new SoundPlayer("Resources\\obratnyiy-otschet-na-ustroystve-27320.wav");
                sp.Stop();
                timer1.Stop();
                Close();
            }
        }

        private void lbl_answer_Click(object sender, EventArgs e)
        {
            var mp3File = TagLib.File.Create(Victorina.answer);
            lbl_answer.Text = mp3File.Tag.FirstAlbumArtist + " - " + mp3File.Tag.Title; ;
        }
    }
}
