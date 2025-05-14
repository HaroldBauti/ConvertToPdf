namespace Infrastructure
{
    public interface IPdfToWordServiceBase
    {
        /// <summary>
        /// Convierte un archivo PDF a formato WORD.
        /// </summary>
        /// <param name="fileOriginPath">Ruta del archivo PDF</param>
        /// <param name="fileDestinationPath">Carpeta donde se guardará el archivo word</param>
        /// <param name="fileName">Nombre del archivo</param>
        /// <returns>
        /// Un valor de <see cref="ConvertStatus"/> que indica el estado de la conversión
        /// </returns>
        ConvertStatus Convert(string fileOriginPath, string fileDestinationPath, string fileName);
    }
}