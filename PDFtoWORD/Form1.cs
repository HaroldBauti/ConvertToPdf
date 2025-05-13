using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SautinSoft;

namespace PDFtoWORD
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog CarpetaSalida;

        private bool convertir = false;

        private string RutaArchivoOrigen;

        private string NombreArchivoOrigen;

        private string RutaArchivoDestino;

        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo PDF(.pdf)|*.pdf";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RutaArchivoOrigen = openFileDialog.FileName;
                NombreArchivoOrigen = Path.GetFileNameWithoutExtension(RutaArchivoOrigen);
                RutaArchivoDestino = Path.GetDirectoryName(RutaArchivoOrigen);
                txtcarpetadestino.Text = RutaArchivoDestino;
                txtcarpetaorigen.Text = RutaArchivoOrigen.ToString();
                convertir = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();
            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtcarpetadestino.Text = CarpetaSalida.SelectedPath;
                RutaArchivoDestino = txtcarpetadestino.Text;
                convertir = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (convertir)
            {
                PdfFocus pdfFocus = new PdfFocus();
                pdfFocus.OpenPdf(RutaArchivoOrigen);
                pdfFocus.ToWord(RutaArchivoDestino + "\\" + NombreArchivoOrigen + ".docx");
                Process.Start(RutaArchivoDestino);
                MessageBox.Show("Archivo Convertido ... ");
            }
        }

        private void btnInf_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.FormClosed += cerrarinf;
            base.Enabled = false;
            form.Show();
        }
        public void cerrarinf(object sender, FormClosedEventArgs e)
        {
            base.Enabled = true;
        }
    }
    
}
