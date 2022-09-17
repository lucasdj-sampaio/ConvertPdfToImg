using ConvertPdfToImage.Model;
using PdfiumViewer;
using System.Drawing;
using System.Drawing.Imaging;

namespace ConvertPdfToImage.Converter
{
    public class ConvertFile
    {
        public (bool, string) Convert(FileModel file, string extension)
        {
            try
            {
                DirectoryInfo GetFileInFolder = new(file.GetFolderPath());
                int qtdPag = 0;

                foreach (var currentFile in GetFileInFolder.GetFiles("*.pdf"))
                {
                    string format2 = file.GetFolderPath() + "\\" + file.GetFileName() + "_PAG-{0}." + extension;

                    using (PdfDocument pdfDocument = PdfDocument.Load(currentFile.FullName))
                    {
                        for (int i = 0; i < pdfDocument.PageCount; i++)
                        {
                            qtdPag++;
                            string text = string.Format(format2, qtdPag);

                            using (Image image = pdfDocument.Render(i, 300f, 300f, forPrinting: false))
                                image.Save(text, GetImageFormat(extension));
                        }
                    }
                }

                return (true, "");
            }
            catch (System.Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public ImageFormat GetImageFormat(string extension)
        {
            extension += extension.ToUpper();

            switch (extension) 
            {
                case ".TIFF":
                    return ImageFormat.Tiff;
                case ".TIF":
                    return ImageFormat.Tiff;
                case ".JPG":
                    return ImageFormat.Jpeg;
                case ".PNG":
                    return ImageFormat.Png;
                case ".JFIF":
                    return ImageFormat.Tiff;
                case ".JPEG":
                    return ImageFormat.Jpeg;
                default:
                    return ImageFormat.Tiff;
            }
        }
    }
}