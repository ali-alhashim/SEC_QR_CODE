using QRCoder;
using System.Drawing.Imaging;

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

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(resultBox.Text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);

            qrCodeImage.Save("qrcode.png", ImageFormat.Png);

            qrCodeBox.Image = qrCodeImage;
        }

        public String GS1func(String textMaterialNo, String textPO, String textVendor,String textExpiry, String textSN)
        {
            String theTextResult = "";
            theTextResult = "91" + textMaterialNo + "^1";
            theTextResult += "400" + textPO + "^1";
            theTextResult += "93" + textVendor + "^1";
            theTextResult += "92" + textExpiry + "^1";
            theTextResult += "21" + textSN + "^1";
            return theTextResult;
        }
    }

    
}
