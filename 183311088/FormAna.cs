using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _183311088
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }
        int move, x, y;

        private void panelBaslik_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panelBaslik_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
            
        }

        private void txtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUst_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if(!txtAlt.Text.Equals("") && !txtUst.Text.Equals(""))
            {
                if (int.Parse(txtAlt.Text)> int.Parse(txtUst.Text))
                {
                    DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtUst.Text), int.Parse(txtAlt.Text), lstSayilar);
                    else
                        txtAlt.Focus();txtAlt.SelectAll();
                }
                else
                    HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtAlt.Text), int.Parse(txtUst.Text), lstSayilar); lblControl.Visible = false;
            }
            else
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Alan Olmamalı!";
                lblControl.Visible = true;
            }
        }

        private void txtAlt_Leave(object sender, EventArgs e)
        {
            if (txtAlt.TextLength <= 0)
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Geçilemez!";
                lblControl.Visible = true;
                txtAlt.Focus();
                txtAlt.SelectAll();
            }
            else if (txtAlt.TextLength <= 1) 
            {
                lblControl.Text = "";
                lblControl.Text = "Basamak Sayısı 2'den Büyük Olmalı";
                lblControl.Visible = true;
                txtAlt.Focus();
                txtAlt.SelectAll();
            }
            else
                lblControl.Visible = false;
        }

        private void txtUst_Leave(object sender, EventArgs e)
        {
            if (txtUst.TextLength <= 1)
            {
                lblControl.Text = "";
                lblControl.Text = "Basamak Sayısı 2'den Büyük Olmalı";
                lblControl.Visible = true;
                txtUst.Focus();
                txtUst.SelectAll();
            }
            else if (txtUst.TextLength <= 0)
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Geçilemez!";
                lblControl.Visible = true;
                txtUst.Focus();
                txtUst.SelectAll();
            }
            else
                lblControl.Visible = false;
        }

        private void txtUst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtAlt.Text.Equals("") && !txtUst.Text.Equals(""))
                {
                    if (int.Parse(txtAlt.Text) > int.Parse(txtUst.Text))
                    {
                        DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                            HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtUst.Text), int.Parse(txtAlt.Text), lstSayilar);
                        else
                            txtAlt.Focus(); txtAlt.SelectAll();
                    }
                    else
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtAlt.Text), int.Parse(txtUst.Text), lstSayilar); lblControl.Visible = false;
                }
                else
                {
                    lblControl.Text = "";
                    lblControl.Text = "Boş Alan Olmamalı!";
                    lblControl.Visible = true;
                }
            }
        }

        private void txtAlt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!txtAlt.Text.Equals("") && !txtUst.Text.Equals(""))
                {
                    if (int.Parse(txtAlt.Text) > int.Parse(txtUst.Text))
                    {
                        DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                            HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtUst.Text), int.Parse(txtAlt.Text), lstSayilar);
                        else
                            txtAlt.Focus(); txtAlt.SelectAll();
                    }
                    else
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtAlt.Text), int.Parse(txtUst.Text), lstSayilar); lblControl.Visible = false;
                }
                else
                {
                    lblControl.Text = "";
                    lblControl.Text = "Boş Alan Olmamalı!";
                    lblControl.Visible = true;
                }
            }
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            HelperMineField.DinamicButton(panelMines);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            HelperMineField.MineCreatedPreview((int)numbericMinesCount.Value, panelMines);
            
        }

        private void panelBaslik_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulama Kapatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
