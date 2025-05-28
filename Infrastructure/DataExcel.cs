using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public struct ingresosFecha
    {
        public DateTime Date { get; set; }
        public decimal Scanner { get; set; }
        public decimal WithoutScanner { get; set; }
    }
    public class DataExcel
    {
        public decimal Ganancia { get; set; }
        public string Problema { get; set; }
        public int Total_Diagnostic = 0;
        public double Suma_Ganacias = 0;
        public double sumaPreciosEstimados = 0;
        public double sumaTiemposDiagnostico = 0;
        public Dictionary<string, double> gananciaPorTecnico = new Dictionary<string, double>();

    }

}
