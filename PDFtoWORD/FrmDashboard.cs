using Infrastructure;
using Microsoft.Win32;
using SpreadsheetLight;
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

namespace PDFtoWORD
{
    public partial class FrmDashboard : Form
    {

        private string _fileOriginPath; List<ingresosFecha> EQA;
         List<DataExcel> dataExcels;
        public FrmDashboard()
        {
            InitializeComponent();
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
            SLDocument document = new SLDocument(_fileOriginPath);
            var sheetNames = document.GetWorksheetNames();
            dataExcels = new List<DataExcel>();
            EQA = new List<ingresosFecha>();
            int cqq = 0;
            DataExcel data;
            for (int sheetIndex = 0; sheetIndex < 2; sheetIndex++)
            {

                data = new DataExcel();
                string hoja = sheetNames[sheetIndex];
                document.SelectWorksheet(hoja);

                var stats = document.GetWorksheetStatistics();
                int lastRow = stats.EndRowIndex;
                int lastCol = stats.EndColumnIndex;


                // Variables para cálculos
                data.Total_Diagnostic = 0;
                data.Suma_Ganacias = 0;
                data.sumaPreciosEstimados = 0;
                data.sumaTiemposDiagnostico = 0;

                for (int row = 2; row <= lastRow; row++)
                {
                    data.Total_Diagnostic++;

                    double precioEstimado = 0;
                    double.TryParse(document.GetCellValueAsString(row, 3), out precioEstimado);
                    double tiempoDiagnostico = 0;
                    double.TryParse(document.GetCellValueAsString(row, 4), out tiempoDiagnostico);
                    ingresosFecha _EQA=new ingresosFecha();
                    _EQA.Date=DateTime.Parse(document.GetCellValueAsString(row, 6).ToString());
                    double ganancia = 0;
                    double.TryParse(document.GetCellValueAsString(row, 7), out ganancia);

                    string tecnico = document.GetCellValueAsString(row, 12);

                    data.sumaPreciosEstimados += precioEstimado;
                    data.sumaTiemposDiagnostico += tiempoDiagnostico;
                    data.Suma_Ganacias += ganancia;
                    if (sheetIndex == 0)
                    {
                        _EQA.Scanner = Convert.ToDecimal(ganancia); 
                    }
                    else
                    {
                        _EQA.WithoutScanner = Convert.ToDecimal(ganancia); 
                    }
                    EQA.Add(_EQA);
                    if (!string.IsNullOrEmpty(tecnico))
                    {
                        if (data.gananciaPorTecnico.ContainsKey(tecnico))
                            data.gananciaPorTecnico[tecnico] += ganancia;
                        else
                           data.gananciaPorTecnico[tecnico] = ganancia;
                    }
                }
                foreach (var kvp in data.gananciaPorTecnico)
                {
                    if (cqq == 0)
                    {
                        dataGridView2.Rows.Add(kvp.Key, kvp.Value);

                    }
                    else
                    {
                        dataGridView2.Rows[cqq-1].Cells[2].Value = kvp.Value;
                        cqq++;
                    }
                }
                cqq++;

                dataExcels.Add(data);
                

            }
            dataGridView1.Rows.Add("Total de Diagnosticos", dataExcels[0].Total_Diagnostic, dataExcels[1].Total_Diagnostic);
            dataGridView1.Rows.Add("Ganacia Total", $"{dataExcels[0].Suma_Ganacias:F2}", $"{dataExcels[1].Suma_Ganacias:F2}");
            dataGridView1.Rows.Add("Precio estimado promedio: S/.", $" {(dataExcels[0].Total_Diagnostic > 0 ? dataExcels[0].sumaPreciosEstimados / dataExcels[0].Total_Diagnostic : 0):F2}", $" {(dataExcels[1].Total_Diagnostic > 0 ? dataExcels[1].sumaPreciosEstimados / dataExcels[1].Total_Diagnostic : 0):F2}");
            dataGridView1.Rows.Add("Tiempo diagnóstico promedio.", $"{(dataExcels[0].Total_Diagnostic > 0 ? dataExcels[0].sumaTiemposDiagnostico / dataExcels[0].Total_Diagnostic : 0):F2} minutos", $":{(dataExcels[1].Total_Diagnostic > 0 ? dataExcels[1].sumaTiemposDiagnostico / dataExcels[1].Total_Diagnostic : 0):F2} minutos");
            ViewData();

        }
        void ViewData()
        {

            var montosPorFecha = EQA
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
