using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            richTextBox1.Text = " ";
            dtp.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.christuniversity.in");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Invalid form. Check the message box for more","Warning",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Enter the name";
            }
            else if ((new Regex(@"^[A-Za-z]+$")).IsMatch(textBox1.Text) == false)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "Enter a valid name";
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Enter the phone number";
            }
            else if ((new Regex(@"^(0|[1-9][0-9]*)$")).IsMatch(textBox2.Text) == false)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text = "Enter a valid phone number";
            }
            else if ((new Regex(@"^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1}){0,1}9[0-9](\s){0,1}(\-){0,1}(\s){0,1}[1-9]{1}[0-9]{7}$")).IsMatch(textBox2.Text) == false)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text = "Enter 10 digit phone number";
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Select a calamity region";
            }
            else if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Select a calamity type";
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Invalid form. Check the message box for more", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                richTextBox1.Text = "Please select yes or no";
            }
            else 
            { 
                richTextBox1.Text = "Submission Successful";
                var myForm = new Form2();
                myForm.Show();
                this.Hide();
            }
        }
    }
}