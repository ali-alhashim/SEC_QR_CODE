using QRCoder;
using System.Drawing.Imaging;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.IO;
using iText.IO.Image;
using System.Diagnostics;
namespace SEC_QR_CODE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            resultBox.Text = GS1func(textMaterialNo.Text, textPO.Text, textVendor.Text, textExpiry.Text, textSN.Text);

           

            qrCodeBox.Image = System.Drawing.Image.FromFile("qrcode.png");
        }

        public String GS1func(String textMaterialNo, String textPO, String textVendor, String textExpiry, String textSN)
        {
            String theTextResult = "";
            theTextResult = "91" + textMaterialNo + "^1";
            theTextResult += "400" + textPO + "^1";
            theTextResult += "93" + textVendor + "^1";
            theTextResult += "92" + textExpiry + "^1";
            theTextResult += "21" + textSN + "^1";

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(theTextResult, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);



            // Save the resized image to a filetry
            try
            {
                qrCodeImage.Save("qrcode.png", ImageFormat.Png);
            }
            catch {
                qrCodeBox.Image.Dispose();
                qrCodeImage.Save("qrcode.png", ImageFormat.Png);
            }
           

           

            return theTextResult;
        }

        static Cell CreateCell(string text)
        {
            return new Cell().Add(new Paragraph(text));
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            Console.WriteLine("user wants to save the pdf file....");
            // ask where to save the pdf file
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Save PDF File";
            saveFileDialog1.FileName = textPO.Text;
            saveFileDialog1.ShowDialog(this);

            if (saveFileDialog1.FileName != "")
            {
                Console.WriteLine("The path for pdf =: ");
                Console.WriteLine(saveFileDialog1.FileName);

                PdfWriter writer  = new PdfWriter(saveFileDialog1.FileName);
                PdfDocument pdf   = new PdfDocument(writer);

               

                // Convert centimeters to points



                float widthCm      = 10f; // Width in centimeters
                float heightCm     = 5f; // Height in centimeters
                float widthPoints  = widthCm * 28.35f;
                float heightPoints = heightCm * 28.35f;

                var pageSize = new PageSize(widthPoints, heightPoints);

                Document document = new Document(pdf, pageSize); // the size let the user select the size of the sticker
                document.SetFontSize(10);
                document.SetMargins(10,0,0,0);
                // Set content alignment to center
                document.SetTextAlignment(TextAlignment.CENTER);


                // Create table
                Table table = new Table(new float[] { 1, 1, 1});

                // Set padding for table cells
                table.SetPadding(2);

                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetHeight(UnitValue.CreatePercentValue(100));

                // Set table margin to 2
                table.SetMargin(5);
                // Adjust table layout
                table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT);
                table.SetVerticalAlignment(VerticalAlignment.TOP);

                // Add table rows
                table.AddCell(CreateCell("Material#"));
                table.AddCell(CreateCell(textMaterialNo.Text));
                Cell qrCodeCell = new Cell(5, 1); // Empty cell for QR code image
                table.AddCell(qrCodeCell);


                // Add table rows
                table.AddCell(CreateCell("PO#"));
                table.AddCell(CreateCell(textPO.Text));
               

                // Add table rows
                table.AddCell(CreateCell("Vendor#"));
                table.AddCell(CreateCell(textVendor.Text));
               

                // Add table rows
                table.AddCell(CreateCell("Expiry"));
                table.AddCell(CreateCell(textExpiry.Text));
                

                // Add table rows
                table.AddCell(CreateCell("Serial#"));
                table.AddCell(CreateCell(textSN.Text));
               



                GS1func(textMaterialNo.Text, textPO.Text, textVendor.Text, textExpiry.Text, textSN.Text);



               
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create("qrcode.png"));

                

                // Scale the image to fit within the maximum dimensions while maintaining aspect ratio
                image.ScaleToFit(100, 100);
                image.SetMargins(0,0,0,0);


               
                qrCodeCell.Add(image);
                qrCodeCell.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                qrCodeCell.SetVerticalAlignment(VerticalAlignment.MIDDLE);
                qrCodeCell.SetTextAlignment(TextAlignment.CENTER);





                // Add table to document
                document.Add(table);

                // Close the document
                document.Close();

                //open with pdf reader
                Process.Start("explorer.exe", saveFileDialog1.FileName);
            }


        }
    }


}
