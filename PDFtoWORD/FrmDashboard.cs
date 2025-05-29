using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain;

namespace PDFtoWORD
{
    public partial class FrmDashboard : Form
    {
        private string _fileOriginPath;
        List<IngresosFecha> _eqa;
        List<DataExcel> _dataExcels;
        private readonly DiagnosticoMecanicoDataLoader _diagnosticoMecanicoLoader;
        public FrmDashboard()
        {
            InitializeComponent();
            _diagnosticoMecanicoLoader = new DiagnosticoMecanicoExcelLoader();
        }

        private void BtnCargarExcel_Click(object sender, EventArgs e)
        {
            var openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "Archive Excel(.xlsx)|*.xlsx";
            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK) return;

            _fileOriginPath = openFileDialog.FileName;

            label1.Text = _fileOriginPath?.ToString();
            CargarDatos();
        }
        private void CargarDatos()
        {
            // dataGridView2.Rows.Add(kvp.Key, kvp.Value);
            // dataGridView2.Rows[cqq-1].Cells[2].Value = kvp.Value;

            (_dataExcels, _eqa) = _diagnosticoMecanicoLoader.CargarDatos(
                rutaArchivo: _fileOriginPath,
                onCqqEquals0: kvp => dataGridView2.Rows.Add(kvp.Key, kvp.Value),
                onCqqDiferent0: (kvp, cqq) => dataGridView2.Rows[cqq-1].Cells[2].Value = kvp.Value
                );
            
            dataGridView1.Rows.Add("Total de Diagnosticos", _dataExcels[0].Total_Diagnostic, _dataExcels[1].Total_Diagnostic);
            dataGridView1.Rows.Add("Ganacia Total", $"{_dataExcels[0].Suma_Ganacias:F2}", $"{_dataExcels[1].Suma_Ganacias:F2}");
            dataGridView1.Rows.Add("Precio estimado promedio: S/.", $" {(_dataExcels[0].Total_Diagnostic > 0 ? _dataExcels[0].sumaPreciosEstimados / _dataExcels[0].Total_Diagnostic : 0):F2}", $" {(_dataExcels[1].Total_Diagnostic > 0 ? _dataExcels[1].sumaPreciosEstimados / _dataExcels[1].Total_Diagnostic : 0):F2}");
            dataGridView1.Rows.Add("Tiempo diagnóstico promedio.", $"{(_dataExcels[0].Total_Diagnostic > 0 ? _dataExcels[0].sumaTiemposDiagnostico / _dataExcels[0].Total_Diagnostic : 0):F2} minutos", $":{(_dataExcels[1].Total_Diagnostic > 0 ? _dataExcels[1].sumaTiemposDiagnostico / _dataExcels[1].Total_Diagnostic : 0):F2} minutos");
            
            var montosPorFecha = _eqa
                .GroupBy(r => new { FechaStr = r.Date.ToString("yyyy-MM-dd")})
                .Select(g => new
                {
                    Fecha = g.Key.FechaStr,
                    TotalMonto = g.Sum(r => r.Scanner),
                    TotalMonto2 = g.Sum(r => r.WithoutScanner)
                }).OrderByDescending(g => g.Fecha);
            
            chart1.Series[0].XValueMember = "Fecha";       // ahora es string
            chart1.Series[0].YValueMembers = "TotalMonto";
            chart1.Series[1].YValueMembers = "TotalMonto2";
            chart1.DataSource = montosPorFecha;
            chart1.DataBind();

        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
