using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coding_Challenge_3
{
    public partial class Form1 : Form
    {
        //global variables
        static Random r = new Random();
        int[] grades = {r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100) };
        Label[] lbl = new Label[8];
        Label[] lbl2 = new Label[8];
        int i = 0, j = 0, k = 0;
        string location = "", target = "";
        //______________________________________________________________________________________________________________________________________________________
        public Form1()
        {
            InitializeComponent();
        }

        //Displaying grades
        private void button1_Click(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;
            btnDisplay.Visible = false;
            for (i = 0; i < 51; i++)
            {
                label1.Location = new Point(label1.Location.X - 1, label1.Location.Y - 1);
                label2.Location = new Point(label2.Location.X + 1, label2.Location.Y - 1);
                label3.Location = new Point(label3.Location.X - 1, label3.Location.Y - 1);
                label4.Location = new Point(label4.Location.X + 1, label4.Location.Y - 1);
                label5.Location = new Point(label5.Location.X - 1, label5.Location.Y - 1);
                label6.Location = new Point(label6.Location.X + 1, label6.Location.Y - 1);
                label7.Location = new Point(label7.Location.X - 1, label7.Location.Y - 1);
                label8.Location = new Point(label8.Location.X + 1, label8.Location.Y - 1);
                System.Threading.Thread.Sleep(50);
            }
            lbl[0] = this.label1;
            lbl[1] = this.label2;
            lbl[2] = this.label3;
            lbl[3] = this.label4;
            lbl[4] = this.label5;
            lbl[5] = this.label6;
            lbl[6] = this.label7;
            lbl[7] = this.label8;
            timer1.Enabled = true;
            lblGrade.Visible = true;
            txtGrade.Visible = true;
            txtGrade.Enabled = true;
            txtGrade.Focus();
        }
        //Searching the data and displaying results
        private void txtGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //when enter key was pressed
            {
                target = txtGrade.Text;
                if (target == "") //if the pressed enter when textbox is empty
                    MessageBox.Show("This field is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //if the textbox is not empty
                {
                    if (!(int.TryParse(target, out int x))) //if the data is not integer
                        FilterGrade();
                    else //if the data is an integer
                    {
                        if ((Convert.ToInt32(target) < 0) || (Convert.ToInt32(target) > 100)) //if data is not a valid grade
                            FilterGrade();
                        else //if data is a valid grade
                        {
                            txtGrade.Enabled = false;
                            lbl2[0] = this.label21;
                            lbl2[1] = this.label22;
                            lbl2[2] = this.label23;
                            lbl2[3] = this.label24;
                            lbl2[4] = this.label25;
                            lbl2[5] = this.label26;
                            lbl2[6] = this.label27;
                            lbl2[7] = this.label28;
                            //enabling the visibility of labels that hold true or false
                            for (int i = 0; i < grades.Length; i++)
                                lbl2[i].Visible = true;
                            timer2.Enabled = true;
                            //getting the index/indices where the target appears
                            for (int l = 0; l < grades.Length; l++) 
                            {
                                if (target == grades[l].ToString())
                                    location += " - " + l;
                            }
                            if (location != "")
                                lblResult.Text = target + " is existing at index/ces " + location + ".";
                            else
                                lblResult.Text = target + " does not exist.";
                        }
                    }
                }
            }
        }

        //button to run again the program without stopping it's execution
        private void btnRetry_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        //Displaying the grades with delay
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j < 8)
            {
                lbl[j].Text = grades[j].ToString();
                j++;
            }
            else
                timer1.Enabled = false;
        }

        //Displaying the result of each element when comparing to the target
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (k < 8)
            {
                if (Convert.ToInt32(target) == grades[k])
                {
                    lbl2[k].ForeColor = Color.LightGreen;
                    lbl2[k].Text = "True";
                }
                else
                {
                    lbl2[k].ForeColor = Color.OrangeRed;
                    lbl2[k].Text = "False";
                }
                k++;
            }
            else //Enabling the visibility of the objects that holds the result and stopping the timer
            {
                groupBox1.Visible = true;
                lblResult.Visible = true;
                btnRetry.Visible = true;
                btnRetry.Enabled = true;
                timer2.Enabled = false;
            }
        }

        //function that shows messagebox if invalid grade was input
        private void FilterGrade()
        {
            MessageBox.Show("Invalid grade!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtGrade.SelectionStart = 0;
            txtGrade.SelectionLength = txtGrade.TextLength;
        }
    }
}
