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
using System.Reflection;

namespace ThisIsWin11_Plugin_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Form2();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newline = Environment.NewLine;
            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "*.ini|*.ini";
            dlg.FileName = textBox1.Text + ".ini";
            dlg.DefaultExt = ".ps1";
            dlg.RestoreDirectory = true;
            dlg.InitialDirectory = exeDir;
            dlg.FilterIndex = 2;
            try
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, "[Info]" + newline + "Name=" + textBox1.Text + newline + "Description=" + textBox2.Text + newline + "Author=" + textBox3.Text + newline + newline + "[Toggle]" + newline + "Enable=" + textBox4.Text + newline + "Disable=" + textBox5.Text + newline + newline + "[Status]" + newline + "Command=" + textBox6.Text + newline + "Type=" + textBox8.Text + newline + "Value=" + textBox7.Text);
                    MessageBox.Show("Plugin saved: " + dlg.FileName, "ThisIsWin11 Plugin Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Operation aborted by the user", "ThisIsWin11 Plugin Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
