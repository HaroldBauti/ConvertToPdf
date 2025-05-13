using System.IO;
using Infrastructure;
using Xunit;

namespace Testing
{
    public class Tests
    {
        [Fact]
        public void PdfToWordConverterTest()
        {
            //* No logre que corriera en linux xd
            IPdfToWordServiceBase converterService = new PdfToWordServiceImpl();
            var currentDirectory = Directory.GetCurrentDirectory();
            var tempDirectory = Path.Combine(currentDirectory, "TestFiles");
            Directory.CreateDirectory(tempDirectory);

            var status = converterService.Convert(Path.Combine(currentDirectory, "random-document.pdf"), tempDirectory, "output");
            Assert.Equal(status, ConvertStatus.Success);
        }
    }
}