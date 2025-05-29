using System;
using System.Collections.Generic;
using Domain;

namespace Infrastructure
{
    public abstract class DiagnosticoMecanicoDataLoader
    {
        /// <summary>
        /// Para cargar datos en base a los parametros
        /// </summary>
        /// <param name="rutaArchivo">La ruta del archivo</param>
        /// <param name="onCqqEquals0">Función para el datagridview, ejemplo: <code> kvp => dataGridView2.Rows.Add(kvp.Key, kvp.Value) </code>
        /// </param>
        /// <param name="onCqqDiferent0">Otra función para el datagridview, ejemplo: <code> (kvp, cqq) => dataGridView2.Rows[cqq-1].Cells[2].Value = kvp.Value</code></param>
        /// <returns></returns>
        public abstract (List<DataExcel>, List<IngresosFecha>) CargarDatos(
            string rutaArchivo,
            Action<KeyValuePair<string, double>> onCqqEquals0 = null,
            Action<KeyValuePair<string, double>, int> onCqqDiferent0 = null
        );
    }
}