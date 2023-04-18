using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Diagnostics;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Enter the name ";
                textBox1.Text = "";
                textBox1.BackColor = Color.LightGray;

            }
            else if ((new Regex(@"^[A-Za-z]+$")).IsMatch(textBox1.Text) == false)
            {
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                richTextBox1.Text = "Enter a valid name";
                textBox1.Text = "";
                textBox1.BackColor = Color.LightGray;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Enter the phone number";
                textBox2.BackColor = Color.LightGray;
            }
            else if ((new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(textBox2.Text) == false)
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                richTextBox1.Text = "Enter a valid phone number ";
                textBox2.BackColor = Color.LightGray;
            }
            else if ((new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$")).IsMatch(textBox2.Text) == false)
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                richTextBox1.Text = "Enter 10 digit phone number ";
                textBox2.BackColor = Color.LightGray;
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Select a calamity region";
                comboBox2.BackColor = Color.LightGray;
            }
            else if (listBox1.SelectedIndex == -1)
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Select a calamity type";
                listBox1.BackColor = Color.LightGray;
            }
            else if ((!radioButton1.Checked) && (!radioButton2.Checked))
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                listBox1.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Select yes or no";
            }
            else if (!checkBox1.Checked)
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                listBox1.BackColor = Color.White;
                MessageBox.Show("Invalid form. Check the message box for more ", " Warning ", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Please check the terms and conditions ";
            }
            else
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                listBox1.BackColor = Color.White;
                richTextBox1.Text = "Submission Successful";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "" ;
            textBox2.Text = "" ;
            comboBox2.Text = "" ;
            listBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            richTextBox1.Text = "" ;
            listBox1.BackColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            { FileName = "https://christuniversity.in/",UseShellExecute = true });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
