using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class myform : Form
    {
        bool Turn = true;
        int counter = 0;
        public myform()
        {
            InitializeComponent();
        }

        private void Exist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You want to close the game", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("thanks about ur time", "Thank u", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void Exist_MouseHover(object sender, EventArgs e)
        {
            Exist.Text = "Sure?";
        }

        private void Exist_MouseLeave(object sender, EventArgs e)
        {
            Exist.Text = "Exit";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Turn)
                b.Text = "X";
            else
                b.Text = "O";

            Turn = !Turn;
            b.Enabled = false;
            counter++;
            Winner();

        }

        private void Winner()
        {
            bool iswinner = false;

            //افقي
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                iswinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                iswinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                iswinner = true;

            //رأسي
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                iswinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B1.Enabled))
                iswinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!C1.Enabled))
                iswinner = true;

            //عمودي
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                iswinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B1.Enabled))
                iswinner = true;



            if (iswinner)
            {
                buttonsoff();
               
                string hero = "";
                if (Turn)
                    hero = "O";
                else
                    hero = "X";

                MessageBox.Show(hero + " is the winner","Wow");
            }
            else
            {
                if (counter == 9)
                    MessageBox.Show("No winners","sorry");
            }
        }

        private void buttonsoff()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;

        }

        private void New_Click(object sender, EventArgs e)
        {
            Turn = true;
            counter = 0;

            A1.Enabled = true;
            A1.Text = "";
            A2.Enabled = true;
            A2.Text = "";
            A3.Enabled = true;
            A3.Text = "";
            B1.Enabled = true;
            B1.Text = "";
            B2.Enabled = true;
            B2.Text = "";
            B3.Enabled = true;
            B3.Text = "";
            C1.Enabled = true;
            C1.Text = "";
            C2.Enabled = true;
            C2.Text = "";
            C3.Enabled = true;
            C3.Text = "";
        }
    }
}