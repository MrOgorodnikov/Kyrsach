namespace Kyrsach
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ean13TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.QRPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EAN13PictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgruondColorButton = new System.Windows.Forms.Button();
            this.moduleColorButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAN13PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ean13TextBox
            // 
            this.ean13TextBox.Location = new System.Drawing.Point(33, 47);
            this.ean13TextBox.Name = "ean13TextBox";
            this.ean13TextBox.Size = new System.Drawing.Size(400, 22);
            this.ean13TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Штрих-код";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(33, 93);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(110, 64);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Згенерувати QR код";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // QRPictureBox
            // 
            this.QRPictureBox.Location = new System.Drawing.Point(33, 200);
            this.QRPictureBox.Name = "QRPictureBox";
            this.QRPictureBox.Size = new System.Drawing.Size(400, 400);
            this.QRPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRPictureBox.TabIndex = 4;
            this.QRPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "QR код";
            // 
            // EAN13PictureBox
            // 
            this.EAN13PictureBox.Location = new System.Drawing.Point(460, 200);
            this.EAN13PictureBox.Name = "EAN13PictureBox";
            this.EAN13PictureBox.Size = new System.Drawing.Size(400, 400);
            this.EAN13PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EAN13PictureBox.TabIndex = 6;
            this.EAN13PictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фото штрих-коду";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(149, 93);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(125, 64);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Вибрати фото штрих-коду";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сфотографувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 641);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(400, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // backgruondColorButton
            // 
            this.backgruondColorButton.Location = new System.Drawing.Point(33, 700);
            this.backgruondColorButton.Name = "backgruondColorButton";
            this.backgruondColorButton.Size = new System.Drawing.Size(110, 56);
            this.backgruondColorButton.TabIndex = 11;
            this.backgruondColorButton.Text = "Колір фону";
            this.backgruondColorButton.UseVisualStyleBackColor = true;
            this.backgruondColorButton.Visible = false;
            this.backgruondColorButton.Click += new System.EventHandler(this.backgruondColorButton_Click);
            // 
            // moduleColorButton
            // 
            this.moduleColorButton.Location = new System.Drawing.Point(163, 700);
            this.moduleColorButton.Name = "moduleColorButton";
            this.moduleColorButton.Size = new System.Drawing.Size(126, 56);
            this.moduleColorButton.TabIndex = 12;
            this.moduleColorButton.Text = "Колір модулів";
            this.moduleColorButton.UseVisualStyleBackColor = true;
            this.moduleColorButton.Visible = false;
            this.moduleColorButton.Click += new System.EventHandler(this.moduleColorButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(306, 703);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(127, 53);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Застосувати";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Visible = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 768);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.moduleColorButton);
            this.Controls.Add(this.backgruondColorButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EAN13PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QRPictureBox);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ean13TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.QRPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAN13PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ean13TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.PictureBox QRPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EAN13PictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button backgruondColorButton;
        private System.Windows.Forms.Button moduleColorButton;
        private System.Windows.Forms.Button applyButton;
    }
}

