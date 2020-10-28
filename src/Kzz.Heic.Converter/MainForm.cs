using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kzz.Heic.Converter
{
    public partial class MainForm : Form
    {
        private readonly MainFormHandler handler;

        public MainForm()
        {
            InitializeComponent();
            this.handler = new MainFormHandler();
        }

        private void FindSource_Click(object sender, EventArgs e)
        {
            this.src.Text = handler.SelectFolder();
        }

        private void FindDest_Click(object sender, EventArgs e)
        {
            this.dest.Text = handler.SelectFolder();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var src = this.src.Text;
            var dst = this.dest.Text;

            try
            {
                if (string.IsNullOrEmpty(src) || (string.IsNullOrEmpty(dst)) || !Directory.Exists(src) || !Directory.Exists(dst))
                {
                    throw new Exception("Asegure que origen y destino existen");
                }

                handler.ConvertDirectory(src, dst);

                MessageBox.Show("Finalizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
