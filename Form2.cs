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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "*.ini|*.ini";
            savefile.RestoreDirectory = true;
            savefile.FileName = "myplugin.ini";
            savefile.InitialDirectory = exeDir;
            savefile.FilterIndex = 2;
            try
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(savefile.FileName, textBox1.Text);
                    MessageBox.Show("Plugin saved: " + savefile.FileName,"ThisIsWin11 Plugin Builder",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Operation aborted by the user","ThisIsWin11 Plugin Builder",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
