using System;
using System.Collections.Generic;
using Domain;
using SpreadsheetLight;

namespace Infrastructure
{
    public class DiagnosticoMecanicoExcelLoader : DiagnosticoMecanicoDataLoader
    {
        override 
        public (List<DataExcel>, List<IngresosFecha>) CargarDatos(String rutaArchivo, Action<KeyValuePair<string, double>> onCqqEquals0 = null, Action<KeyValuePair<string, double>, int> onCqqDiferent0 = null)
        {
            // Nullable
            onCqqEquals0 = onCqqEquals0 ?? (_ => {});
            onCqqDiferent0 = onCqqDiferent0 ?? ((_, __) => {});
            
            var document = new SLDocument(rutaArchivo);
            var sheetNames = document.GetWorksheetNames();
            
            var dataExcels = new List<DataExcel>();
            var eqa = new List<IngresosFecha>();
            
            int cqq = 0;
            for (int sheetIndex = 0; sheetIndex < 2; sheetIndex++)
            {
                var data = new DataExcel();
                string hoja = sheetNames[sheetIndex];
                document.SelectWorksheet(hoja);

                var stats = document.GetWorksheetStatistics();
                var lastRow = stats.EndRowIndex;
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
                    
                    IngresosFecha dataEQA = new IngresosFecha();
                    dataEQA.Date=DateTime.Parse(document.GetCellValueAsString(row, 6).ToString());
                    
                    double ganancia = 0;
                    double.TryParse(document.GetCellValueAsString(row, 7), out ganancia);

                    string tecnico = document.GetCellValueAsString(row, 12);

                    data.sumaPreciosEstimados += precioEstimado;
                    data.sumaTiemposDiagnostico += tiempoDiagnostico;
                    data.Suma_Ganacias += ganancia;
                    if (sheetIndex == 0)
                    {
                        dataEQA.Scanner = Convert.ToDecimal(ganancia); 
                    }
                    else
                    {
                        dataEQA.WithoutScanner = Convert.ToDecimal(ganancia); 
                    }
                    eqa.Add(dataEQA);
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
                        onCqqEquals0(kvp);
                    }
                    else
                    {
                        onCqqDiferent0(kvp, cqq);
                        cqq++;
                    }
                }
                cqq++;

                dataExcels.Add(data);
            }

            return (dataExcels, eqa);
        }
    }
}