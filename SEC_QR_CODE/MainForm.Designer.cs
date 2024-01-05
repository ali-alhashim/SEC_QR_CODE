namespace SEC_QR_CODE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSavePDF = new Button();
            btnLogs = new Button();
            textMaterialNo = new TextBox();
            label1 = new Label();
            textPO = new TextBox();
            label2 = new Label();
            textVendor = new TextBox();
            label3 = new Label();
            textExpiry = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textSN = new TextBox();
            resultBox = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnResult = new Button();
            qrCodeBox = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)qrCodeBox).BeginInit();
            SuspendLayout();
            // 
            // btnSavePDF
            // 
            btnSavePDF.Location = new Point(12, 415);
            btnSavePDF.Name = "btnSavePDF";
            btnSavePDF.Size = new Size(75, 23);
            btnSavePDF.TabIndex = 1;
            btnSavePDF.Text = "Save PDF ";
            btnSavePDF.UseVisualStyleBackColor = true;
            btnSavePDF.Click += btnSavePDF_Click;
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(713, 415);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(75, 23);
            btnLogs.TabIndex = 2;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // textMaterialNo
            // 
            textMaterialNo.Location = new Point(135, 34);
            textMaterialNo.Name = "textMaterialNo";
            textMaterialNo.Size = new Size(320, 23);
            textMaterialNo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Material No";
            // 
            // textPO
            // 
            textPO.Location = new Point(135, 63);
            textPO.Name = "textPO";
            textPO.Size = new Size(320, 23);
            textPO.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Purchase Order";
            // 
            // textVendor
            // 
            textVendor.Location = new Point(135, 92);
            textVendor.Name = "textVendor";
            textVendor.Size = new Size(320, 23);
            textVendor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 95);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Vendor";
            // 
            // textExpiry
            // 
            textExpiry.Location = new Point(135, 121);
            textExpiry.Name = "textExpiry";
            textExpiry.Size = new Size(320, 23);
            textExpiry.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 124);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Expiry";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 153);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 11;
            label5.Text = "Serial Number";
            // 
            // textSN
            // 
            textSN.Location = new Point(135, 150);
            textSN.Name = "textSN";
            textSN.Size = new Size(320, 23);
            textSN.TabIndex = 12;
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Location = new Point(135, 208);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(429, 96);
            resultBox.TabIndex = 13;
            resultBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 248);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 14;
            label6.Text = "Text";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 124);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 15;
            label7.Text = "example date : 23.02.2022";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(608, 124);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 16;
            label8.Text = "GS1 = 92";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(461, 37);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 17;
            label9.Text = "GS1 = 91";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(461, 66);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 18;
            label10.Text = "GS1 = 400";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(461, 95);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 19;
            label11.Text = "GS1 = 93";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(461, 153);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 20;
            label12.Text = "GS1 = 21";
            // 
            // btnResult
            // 
            btnResult.Location = new Point(135, 310);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 23);
            btnResult.TabIndex = 21;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // qrCodeBox
            // 
            qrCodeBox.BackColor = SystemColors.ActiveCaption;
            qrCodeBox.Location = new Point(570, 208);
            qrCodeBox.Name = "qrCodeBox";
            qrCodeBox.Size = new Size(100, 96);
            qrCodeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrCodeBox.TabIndex = 22;
            qrCodeBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(qrCodeBox);
            Controls.Add(btnResult);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(resultBox);
            Controls.Add(textSN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textExpiry);
            Controls.Add(label3);
            Controls.Add(textVendor);
            Controls.Add(label2);
            Controls.Add(textPO);
            Controls.Add(label1);
            Controls.Add(textMaterialNo);
            Controls.Add(btnLogs);
            Controls.Add(btnSavePDF);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SEC QR CODE Creator - By Ali  Al-Hashim";
            ((System.ComponentModel.ISupportInitialize)qrCodeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSavePDF;
        private Button btnLogs;
        private TextBox textMaterialNo;
        private Label label1;
        private TextBox textPO;
        private Label label2;
        private TextBox textVendor;
        private Label label3;
        private TextBox textExpiry;
        private Label label4;
        private Label label5;
        private TextBox textSN;
        private RichTextBox resultBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnResult;
        private PictureBox qrCodeBox;
        private SaveFileDialog saveFileDialog1;
    }
}
