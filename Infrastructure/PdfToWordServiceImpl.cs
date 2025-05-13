using System.Diagnostics;
using SautinSoft;

namespace Infrastructure
{
    public class PdfToWordServiceImpl : IPdfToWordServiceBase
    {
        public ConvertStatus Convert(string fileOriginPath, string fileDestinationPath, string fileName)
        {
            var pdfFocus = new PdfFocus();
            pdfFocus.OpenPdf(fileOriginPath);
            var convertedStatus = (ConvertStatus)pdfFocus.ToWord(fileDestinationPath + "\\" + fileName + ".docx");
            
            if (convertedStatus != ConvertStatus.Success) return convertedStatus; 
            Process.Start(fileDestinationPath);
            return convertedStatus;
        }
    }
}