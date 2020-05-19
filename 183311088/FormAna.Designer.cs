namespace _183311088
{
    partial class FormAna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.panelSoruIkı = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.txtUst = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.lblUstSinir = new System.Windows.Forms.Label();
            this.lblAltSinir = new System.Windows.Forms.Label();
            this.lblSayiBaslik = new System.Windows.Forms.Label();
            this.lblSoruIkı = new System.Windows.Forms.Label();
            this.lblSoruBir = new System.Windows.Forms.Label();
            this.panelMines = new System.Windows.Forms.Panel();
            this.grpboxGiris = new System.Windows.Forms.GroupBox();
            this.numericSure = new System.Windows.Forms.NumericUpDown();
            this.numbericMinesCount = new System.Windows.Forms.NumericUpDown();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblMayinSayisi = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.lblFormBaslik = new System.Windows.Forms.Label();
            this.pictureboxFormIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelSoruIkı.SuspendLayout();
            this.grpboxGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericMinesCount)).BeginInit();
            this.panelBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoruIkı
            // 
            this.panelSoruIkı.BackColor = System.Drawing.Color.DarkGray;
            this.panelSoruIkı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSoruIkı.Controls.Add(this.lblControl);
            this.panelSoruIkı.Controls.Add(this.btnBul);
            this.panelSoruIkı.Controls.Add(this.lblAltBaslik);
            this.panelSoruIkı.Controls.Add(this.lstSayilar);
            this.panelSoruIkı.Controls.Add(this.txtUst);
            this.panelSoruIkı.Controls.Add(this.txtAlt);
            this.panelSoruIkı.Controls.Add(this.lblUstSinir);
            this.panelSoruIkı.Controls.Add(this.lblAltSinir);
            this.panelSoruIkı.Controls.Add(this.lblSayiBaslik);
            this.panelSoruIkı.Controls.Add(this.lblSoruIkı);
            this.panelSoruIkı.Location = new System.Drawing.Point(239, 36);
            this.panelSoruIkı.Name = "panelSoruIkı";
            this.panelSoruIkı.Size = new System.Drawing.Size(233, 369);
            this.panelSoruIkı.TabIndex = 0;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.ForeColor = System.Drawing.Color.Red;
            this.lblControl.Location = new System.Drawing.Point(23, 150);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(0, 13);
            this.lblControl.TabIndex = 10;
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControl.Visible = false;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBul.Location = new System.Drawing.Point(137, 251);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(78, 31);
            this.btnBul.TabIndex = 6;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblAltBaslik
            // 
            this.lblAltBaslik.BackColor = System.Drawing.Color.DarkGray;
            this.lblAltBaslik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAltBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltBaslik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAltBaslik.Location = new System.Drawing.Point(12, 292);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(203, 65);
            this.lblAltBaslik.TabIndex = 9;
            this.lblAltBaslik.Text = "Armstrong Sayısı";
            this.lblAltBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSayilar
            // 
            this.lstSayilar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.ItemHeight = 14;
            this.lstSayilar.Location = new System.Drawing.Point(12, 168);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(119, 116);
            this.lstSayilar.TabIndex = 8;
            // 
            // txtUst
            // 
            this.txtUst.Location = new System.Drawing.Point(113, 127);
            this.txtUst.MaxLength = 6;
            this.txtUst.Name = "txtUst";
            this.txtUst.Size = new System.Drawing.Size(102, 20);
            this.txtUst.TabIndex = 7;
            this.txtUst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUst_KeyDown);
            this.txtUst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUst_KeyPress);
            this.txtUst.Leave += new System.EventHandler(this.txtUst_Leave);
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(12, 127);
            this.txtAlt.MaxLength = 6;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(95, 20);
            this.txtAlt.TabIndex = 6;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlt_KeyDown);
            this.txtAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlt_KeyPress);
            this.txtAlt.Leave += new System.EventHandler(this.txtAlt_Leave);
            // 
            // lblUstSinir
            // 
            this.lblUstSinir.BackColor = System.Drawing.Color.Azure;
            this.lblUstSinir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUstSinir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUstSinir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUstSinir.Location = new System.Drawing.Point(113, 101);
            this.lblUstSinir.Name = "lblUstSinir";
            this.lblUstSinir.Size = new System.Drawing.Size(102, 23);
            this.lblUstSinir.TabIndex = 5;
            this.lblUstSinir.Text = "Üst Sınır";
            this.lblUstSinir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAltSinir
            // 
            this.lblAltSinir.BackColor = System.Drawing.Color.Azure;
            this.lblAltSinir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAltSinir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltSinir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAltSinir.Location = new System.Drawing.Point(12, 101);
            this.lblAltSinir.Name = "lblAltSinir";
            this.lblAltSinir.Size = new System.Drawing.Size(95, 23);
            this.lblAltSinir.TabIndex = 4;
            this.lblAltSinir.Text = "Alt Sınır";
            this.lblAltSinir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayiBaslik
            // 
            this.lblSayiBaslik.BackColor = System.Drawing.Color.Azure;
            this.lblSayiBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSayiBaslik.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayiBaslik.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSayiBaslik.Location = new System.Drawing.Point(12, 74);
            this.lblSayiBaslik.Name = "lblSayiBaslik";
            this.lblSayiBaslik.Size = new System.Drawing.Size(203, 23);
            this.lblSayiBaslik.TabIndex = 3;
            this.lblSayiBaslik.Text = "- SAYI -";
            this.lblSayiBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoruIkı
            // 
            this.lblSoruIkı.BackColor = System.Drawing.Color.LightBlue;
            this.lblSoruIkı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoruIkı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruIkı.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSoruIkı.Location = new System.Drawing.Point(12, 6);
            this.lblSoruIkı.Name = "lblSoruIkı";
            this.lblSoruIkı.Size = new System.Drawing.Size(203, 23);
            this.lblSoruIkı.TabIndex = 2;
            this.lblSoruIkı.Text = "SORU 2 :";
            this.lblSoruIkı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoruBir
            // 
            this.lblSoruBir.BackColor = System.Drawing.Color.LightBlue;
            this.lblSoruBir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSoruBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruBir.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSoruBir.Location = new System.Drawing.Point(7, 44);
            this.lblSoruBir.Name = "lblSoruBir";
            this.lblSoruBir.Size = new System.Drawing.Size(212, 23);
            this.lblSoruBir.TabIndex = 1;
            this.lblSoruBir.Text = "SORU 1 :";
            this.lblSoruBir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMines
            // 
            this.panelMines.BackColor = System.Drawing.SystemColors.Info;
            this.panelMines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMines.Location = new System.Drawing.Point(10, 70);
            this.panelMines.Name = "panelMines";
            this.panelMines.Size = new System.Drawing.Size(209, 206);
            this.panelMines.TabIndex = 1;
            // 
            // grpboxGiris
            // 
            this.grpboxGiris.Controls.Add(this.numericSure);
            this.grpboxGiris.Controls.Add(this.numbericMinesCount);
            this.grpboxGiris.Controls.Add(this.lblSure);
            this.grpboxGiris.Controls.Add(this.lblMayinSayisi);
            this.grpboxGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxGiris.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpboxGiris.Location = new System.Drawing.Point(10, 282);
            this.grpboxGiris.Name = "grpboxGiris";
            this.grpboxGiris.Size = new System.Drawing.Size(209, 79);
            this.grpboxGiris.TabIndex = 2;
            this.grpboxGiris.TabStop = false;
            this.grpboxGiris.Text = "Paremetreler";
            // 
            // numericSure
            // 
            this.numericSure.Location = new System.Drawing.Point(91, 42);
            this.numericSure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSure.Name = "numericSure";
            this.numericSure.Size = new System.Drawing.Size(112, 21);
            this.numericSure.TabIndex = 5;
            this.numericSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericSure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numbericMinesCount
            // 
            this.numbericMinesCount.Location = new System.Drawing.Point(91, 17);
            this.numbericMinesCount.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numbericMinesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbericMinesCount.Name = "numbericMinesCount";
            this.numbericMinesCount.Size = new System.Drawing.Size(112, 21);
            this.numbericMinesCount.TabIndex = 5;
            this.numbericMinesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numbericMinesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSure.Location = new System.Drawing.Point(6, 42);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(78, 23);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "Süre (sn) =";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMayinSayisi
            // 
            this.lblMayinSayisi.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMayinSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayinSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMayinSayisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMayinSayisi.Location = new System.Drawing.Point(6, 17);
            this.lblMayinSayisi.Name = "lblMayinSayisi";
            this.lblMayinSayisi.Size = new System.Drawing.Size(78, 23);
            this.lblMayinSayisi.TabIndex = 3;
            this.lblMayinSayisi.Text = "Mayın Sayısı =";
            this.lblMayinSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.BackColor = System.Drawing.Color.SkyBlue;
            this.lblKalanSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKalanSure.Location = new System.Drawing.Point(10, 364);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(138, 30);
            this.lblKalanSure.TabIndex = 3;
            this.lblKalanSure.Text = "Kalan Süre = __";
            this.lblKalanSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBasla.Location = new System.Drawing.Point(154, 363);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(65, 31);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.White;
            this.panelBaslik.Controls.Add(this.lblFormBaslik);
            this.panelBaslik.Controls.Add(this.pictureboxFormIcon);
            this.panelBaslik.Controls.Add(this.btnExit);
            this.panelBaslik.Location = new System.Drawing.Point(-2, 0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(482, 33);
            this.panelBaslik.TabIndex = 6;
            this.panelBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBaslik_MouseDown);
            this.panelBaslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBaslik_MouseMove);
            this.panelBaslik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelBaslik_MouseUp);
            // 
            // lblFormBaslik
            // 
            this.lblFormBaslik.AutoSize = true;
            this.lblFormBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormBaslik.Location = new System.Drawing.Point(37, 10);
            this.lblFormBaslik.Name = "lblFormBaslik";
            this.lblFormBaslik.Size = new System.Drawing.Size(30, 15);
            this.lblFormBaslik.TabIndex = 7;
            this.lblFormBaslik.Text = "Vize";
            // 
            // pictureboxFormIcon
            // 
            this.pictureboxFormIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxFormIcon.Image")));
            this.pictureboxFormIcon.Location = new System.Drawing.Point(9, 4);
            this.pictureboxFormIcon.Name = "pictureboxFormIcon";
            this.pictureboxFormIcon.Size = new System.Drawing.Size(26, 26);
            this.pictureboxFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxFormIcon.TabIndex = 6;
            this.pictureboxFormIcon.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(443, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseCompatibleTextRendering = true;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 406);
            this.Controls.Add(this.panelBaslik);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.grpboxGiris);
            this.Controls.Add(this.panelMines);
            this.Controls.Add(this.lblSoruBir);
            this.Controls.Add(this.panelSoruIkı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAna";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vize";
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.panelSoruIkı.ResumeLayout(false);
            this.panelSoruIkı.PerformLayout();
            this.grpboxGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericMinesCount)).EndInit();
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoruIkı;
        private System.Windows.Forms.Label lblSoruIkı;
        private System.Windows.Forms.Label lblSoruBir;
        private System.Windows.Forms.Panel panelMines;
        private System.Windows.Forms.GroupBox grpboxGiris;
        private System.Windows.Forms.Label lblMayinSayisi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblAltBaslik;
        private System.Windows.Forms.ListBox lstSayilar;
        private System.Windows.Forms.TextBox txtUst;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Label lblUstSinir;
        private System.Windows.Forms.Label lblAltSinir;
        private System.Windows.Forms.Label lblSayiBaslik;
        private System.Windows.Forms.NumericUpDown numericSure;
        private System.Windows.Forms.NumericUpDown numbericMinesCount;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureboxFormIcon;
        private System.Windows.Forms.Label lblFormBaslik;
        private System.Windows.Forms.Label lblControl;
    }
}

