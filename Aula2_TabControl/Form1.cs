using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                mkdData.Focus();
            }

            else if (txtEvento == null)
            {

                txtEvento.Focus();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                try
                {
                    DateTime data = Convert.ToDateTime(mkdData.Text);
                    listBox1.Items.Add(txtEvento.Text);
                    listBox2.Items.Add(mkdData.Text);
                    txtEvento.Clear();
                    mkdData.Clear();
                    txtEvento.Focus();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Data Invalida");
                    mkdData.Focus();
                }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 1)
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 2)
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            else
                MessageBox.Show("Selecione um candidato!");
            listBox3.ClearSelected();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkdData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {

                listBox1.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }
    }