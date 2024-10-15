using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PR_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkST_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkST.LinkVisited = true;
            System.Diagnostics.Process.Start("https://steamcommunity.com/profiles/76561198802886757/");
        }

        private void pictureBobobo_Click(object sender, EventArgs e)
        {
            ImageAnimator.UpdateFrames();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
