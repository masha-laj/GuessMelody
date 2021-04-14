using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuessMelodyWF
{
    public partial class FSet : Form
    {
        public FSet()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Victorina.allDirectories = cb_alldirectories.Checked;
            Victorina.gameDuration = Convert.ToInt32(cb_gameduration.Text);
            Victorina.musicDuration = Convert.ToInt32(cb_musicduration.Text);
            Victorina.randomStart = cb_randomstart.Checked;
            Victorina.WriteParam();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(fbd.SelectedPath, "*.mp3", cb_alldirectories.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
                Victorina.lastFolder = fbd.SelectedPath;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(music_list);
                Victorina.list.Clear();
                Victorina.list.AddRange(music_list);
            };
        }

        void Set()
        {
            cb_alldirectories.Checked = Victorina.allDirectories;
            cb_gameduration.Text = Victorina.gameDuration.ToString();
            cb_musicduration.Text = Victorina.musicDuration.ToString();
            cb_randomstart.Checked = Victorina.randomStart;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Set();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Victorina.list.ToArray());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Victorina.list.Clear();
            Victorina.lastFolder = "";
            Victorina.WriteParam();
        }
    }
}
