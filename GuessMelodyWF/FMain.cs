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
    public partial class FMain : Form
    {
        FSet f2 = new FSet();
        FGame f3 = new FGame();

        public FMain()
        {
            InitializeComponent();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            f3.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Victorina.ReadParam();
            Victorina.ReadMusic();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_memo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\shali\Desktop\Sharaga\Шимбирев\Курсач_3курс\Памятка игрокам.txt");
        }
    }
}
