using System;
using System.IO;
using System.Windows.Forms;
using Infrastructure;

namespace PDFtoWORD
{
    public partial class Form1 : Form
    {
        private readonly IPdfToWordServiceBase _pdfToWordService;
        
        private FolderBrowserDialog _destinationFolder;

        private bool _convert = false;

        private string _fileOriginPath;

        private string _fileOriginName;

        private string _fileDestinationPath;

        public Form1()
        {
            InitializeComponent();
            _pdfToWordService = new PdfToWordServiceImpl();
        }

        private void BtnExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizeWindow(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archive PDF(.pdf)|*.pdf";
            var dialogResult = openFileDialog.ShowDialog();
            
            if (dialogResult != DialogResult.OK) return;
            
            _fileOriginPath = openFileDialog.FileName;
            _fileOriginName = Path.GetFileNameWithoutExtension(_fileOriginPath);
            _fileDestinationPath = Path.GetDirectoryName(_fileOriginPath);
            
            destionationFolderTextBox.Text = _fileDestinationPath;
            originFolderTextBox.Text = _fileOriginPath?.ToString();
            _convert = true;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            _destinationFolder = new FolderBrowserDialog();
            if (_destinationFolder.ShowDialog() != DialogResult.OK) return;
            destionationFolderTextBox.Text = _destinationFolder.SelectedPath;
            _fileDestinationPath = destionationFolderTextBox.Text;
            _convert = true;
        }

        private void BtnConvertClick(object sender, EventArgs e)
        {
            if (!_convert) return;
            var status = _pdfToWordService.Convert(_fileOriginPath, _fileDestinationPath, _fileOriginName);
            MessageBox.Show(status == ConvertStatus.Success
                ? "Archivo Convertido ... "
                : "Personaliza esto en base al status o algo asi"
            );
        }

        private void BtnInformationClick(object sender, EventArgs e)
        {
            var form = new Form2();
            form.FormClosed += CloseInformation;
            base.Enabled = false;
            form.Show();
        }

        private void CloseInformation(object sender, FormClosedEventArgs e)
        {
            base.Enabled = true;
        }
    }
    
}
