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
namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fhijo objetohijo = new fhijo();
            objetohijo.MdiParent = this;
            objetohijo.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            fhijo objetohijo = (fhijo)this.ActiveMdiChild;
            if (objetohijo != null)
            {
                objetohijo.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                this.MdiChildren[i].WindowState = FormWindowState.Minimized;
            }
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdabrir = new OpenFileDialog();
            ofdabrir.Filter = "Documento de texto(*.txt) | *.txt";
            ofdabrir.Title = "Abrir documento de Texto";
            if (ofdabrir.ShowDialog() == DialogResult.OK)
            {
                StreamReader textoarchivo = File.OpenText(ofdabrir.FileName);
                objetohijo.Text = textoarchivo.ReadToEnd();
                textoarchivo.Close();

            }
            ofdabrir.Dispose();


        }





        private void objetohijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    } }
    
