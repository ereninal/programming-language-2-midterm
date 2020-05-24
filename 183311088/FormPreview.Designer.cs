namespace _183311088
{
    partial class FormPreview
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
            this.panelMine = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelMine
            // 
            this.panelMine.BackColor = System.Drawing.SystemColors.Info;
            this.panelMine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMine.Location = new System.Drawing.Point(1, 3);
            this.panelMine.Name = "panelMine";
            this.panelMine.Size = new System.Drawing.Size(209, 206);
            this.panelMine.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // FormPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 208);
            this.Controls.Add(this.panelMine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Önizleme Ekranı";
            this.Load += new System.EventHandler(this.FormPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMine;
        public System.Windows.Forms.Timer refresh;
    }
}