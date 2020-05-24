namespace _183311088
{
    partial class FormCenter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCenter));
            this.panelSoruIkı = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.txtUst = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.lblUstSinir = new System.Windows.Forms.Label();
            this.lblAltSinir = new System.Windows.Forms.Label();
            this.lblSayiBaslik = new System.Windows.Forms.Label();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQestion1 = new System.Windows.Forms.Label();
            this.panelMines = new System.Windows.Forms.Panel();
            this.grpboxGiris = new System.Windows.Forms.GroupBox();
            this.numericSure = new System.Windows.Forms.NumericUpDown();
            this.numbericMinesCount = new System.Windows.Forms.NumericUpDown();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblMayinSayisi = new System.Windows.Forms.Label();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFormBaslik = new System.Windows.Forms.Label();
            this.pictureboxFormIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panelSoruIkı.SuspendLayout();
            this.grpboxGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericMinesCount)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoruIkı
            // 
            this.panelSoruIkı.BackColor = System.Drawing.Color.DarkGray;
            this.panelSoruIkı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSoruIkı.Controls.Add(this.lblControl);
            this.panelSoruIkı.Controls.Add(this.btnSearch);
            this.panelSoruIkı.Controls.Add(this.lblFooter);
            this.panelSoruIkı.Controls.Add(this.listNumbers);
            this.panelSoruIkı.Controls.Add(this.txtUst);
            this.panelSoruIkı.Controls.Add(this.txtAlt);
            this.panelSoruIkı.Controls.Add(this.lblUstSinir);
            this.panelSoruIkı.Controls.Add(this.lblAltSinir);
            this.panelSoruIkı.Controls.Add(this.lblSayiBaslik);
            this.panelSoruIkı.Controls.Add(this.lblQuestion2);
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(137, 251);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Bul";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.DarkGray;
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFooter.Location = new System.Drawing.Point(12, 292);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(203, 65);
            this.lblFooter.TabIndex = 9;
            this.lblFooter.Text = "Armstrong Sayısı";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listNumbers
            // 
            this.listNumbers.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.ItemHeight = 14;
            this.listNumbers.Location = new System.Drawing.Point(12, 168);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(119, 116);
            this.listNumbers.TabIndex = 8;
            this.listNumbers.Tag = "";
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
            // lblQuestion2
            // 
            this.lblQuestion2.BackColor = System.Drawing.Color.LightBlue;
            this.lblQuestion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion2.ForeColor = System.Drawing.SystemColors.Info;
            this.lblQuestion2.Location = new System.Drawing.Point(12, 6);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(203, 23);
            this.lblQuestion2.TabIndex = 2;
            this.lblQuestion2.Text = "SORU 2 :";
            this.lblQuestion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQestion1
            // 
            this.lblQestion1.BackColor = System.Drawing.Color.LightBlue;
            this.lblQestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQestion1.ForeColor = System.Drawing.SystemColors.Info;
            this.lblQestion1.Location = new System.Drawing.Point(7, 44);
            this.lblQestion1.Name = "lblQestion1";
            this.lblQestion1.Size = new System.Drawing.Size(212, 23);
            this.lblQestion1.TabIndex = 1;
            this.lblQestion1.Text = "SORU 1 :";
            this.lblQestion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(154, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 31);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblFormBaslik);
            this.panelHeader.Controls.Add(this.pictureboxFormIcon);
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Location = new System.Drawing.Point(-2, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(482, 33);
            this.panelHeader.TabIndex = 6;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
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
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // FormCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 406);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.grpboxGiris);
            this.Controls.Add(this.panelMines);
            this.Controls.Add(this.lblQestion1);
            this.Controls.Add(this.panelSoruIkı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCenter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vize";
            this.Load += new System.EventHandler(this.FormCenter_Load);
            this.panelSoruIkı.ResumeLayout(false);
            this.panelSoruIkı.PerformLayout();
            this.grpboxGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericMinesCount)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSoruIkı;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQestion1;
        private System.Windows.Forms.Panel panelMines;
        private System.Windows.Forms.GroupBox grpboxGiris;
        private System.Windows.Forms.Label lblMayinSayisi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.TextBox txtUst;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.Label lblUstSinir;
        private System.Windows.Forms.Label lblAltSinir;
        private System.Windows.Forms.Label lblSayiBaslik;
        private System.Windows.Forms.NumericUpDown numericSure;
        private System.Windows.Forms.NumericUpDown numbericMinesCount;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureboxFormIcon;
        private System.Windows.Forms.Label lblFormBaslik;
        private System.Windows.Forms.Label lblControl;
        public System.Windows.Forms.Label lblKalanSure;
        public System.Windows.Forms.Timer time;
    }
}

