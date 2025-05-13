namespace Infrastructure
{
    /// <summary>
    /// Representa el valor del resultado de una conversión
    /// </summary>
    public enum ConvertStatus
    {
        /// <summary> Operación exitosa </summary>
        Success = 0,
        
        /// <summary> No se pudo convertir el archivo, checar la ruta de destino </summary>
        Fail = 2,
        
        /// <summary> Ha habido problemas internos con el paquete para la conversión, contactar a: <a href="mailto:support@sautinsoft.com">support@sautinsoft.com</a>. </summary>
        UnexpectedError = 3
    }
}