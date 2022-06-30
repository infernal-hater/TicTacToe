using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dop5
{
    public partial class Form1 : Form
    {
        private int player;
        public Form1()
        {
            InitializeComponent();
            
            player = 1;
            label1.Text = "Текущий ход: Игрок 1";
        }

        public void DisableButtons ()
        {
            b_a1.Enabled = false;
            b_a2.Enabled = false;
            b_a3.Enabled = false;
            b_b1.Enabled = false;
            b_b2.Enabled = false;
            b_b3.Enabled = false;
            b_c1.Enabled = false;
            b_c2.Enabled = false;
            b_c3.Enabled = false;
        }

        public void Win(string who) {
            string message = string.Format("{0} победили!", who);
            MessageBox.Show(message);
            DisableButtons();
        }

        private void b_a1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    label1.Text = "Текущий ход: Игрок 2";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "0");
                    player = 1;
                    label1.Text = "Текущий ход: Игрок 1";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }
        private void checkWin()
        {
            string who;
            if (b_a1.Text == b_a2.Text && b_a2.Text == b_a3.Text && b_a2.Text != "")
            {
                who = b_a2.Text;
                Win(who);
                return;

            }
            if (b_b1.Text == b_b2.Text && b_b2.Text == b_b3.Text && b_b1.Text != "")
            {
                who = b_b1.Text;
                Win(who);
                return;
            }
            if (b_c1.Text == b_c2.Text && b_c2.Text == b_c3.Text && b_c1.Text != "")
            {
                who = b_c1.Text;
                Win(who);
                return;
            }
            if (b_a1.Text == b_b1.Text && b_b1.Text == b_c1.Text && b_b1.Text != "")
            {
                who = b_b1.Text;
                Win(who);
                return;
            }
            if (b_a2.Text == b_b2.Text && b_b2.Text == b_c2.Text && b_a2.Text != "")
            {
                who = b_a2.Text;
                Win(who);
                return;
            }
            if (b_a3.Text == b_b3.Text && b_b3.Text == b_c3.Text && b_a3.Text != "")
            {
                who = b_a3.Text;
                Win(who);
                return;
            }
            if (b_a1.Text == b_b2.Text && b_b2.Text == b_c3.Text && b_b2.Text != "")
            {
                who = b_b2.Text;
                Win(who);
                return;
            }
            if (b_a3.Text == b_b2.Text && b_b2.Text == b_c1.Text && b_a3.Text != "")
            {
                who = b_a3.Text;
                Win(who);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_a10_Click(object sender, EventArgs e)
        {
            b_a1.Text = "";
            b_a2.Text = "";
            b_a3.Text = "";
            b_b1.Text = "";
            b_b2.Text = "";
            b_b3.Text = "";
            b_c1.Text = "";
            b_c2.Text = "";
            b_c3.Text = "";

            b_a1.Enabled = true;
            b_a2.Enabled = true;
            b_a3.Enabled = true;
            b_b1.Enabled = true;
            b_b2.Enabled = true;
            b_b3.Enabled = true;
            b_c1.Enabled = true;
            b_c2.Enabled = true;
            b_c3.Enabled = true;

            player = 1;
            label1.Text = "Текущий ход: Игрок 1";
        }
    }
}
