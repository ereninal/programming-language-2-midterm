﻿using System;
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
    public partial class FormCenter : Form
    {
        public FormCenter()
        {
            InitializeComponent();
        }
        FormPreview _FormPreview; 
        #region ArmStrong
        int move, x, y;
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (!txtMin.Text.Equals("") && !txtMax.Text.Equals(""))
            {
                if (int.Parse(txtMin.Text) > int.Parse(txtMax.Text))
                {
                    DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMax.Text), int.Parse(txtMin.Text), listNumbers);
                    else
                        txtMin.Focus(); txtMin.SelectAll();
                }
                else
                    HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMin.Text), int.Parse(txtMax.Text), listNumbers); lblControl.Visible = false;
            }
            else
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Alan Olmamalı!";
                lblControl.Visible = true;
            }
        }
        #endregion
        #region MyControlArmstrong

        private void txtAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUst_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAlt_Leave(object sender, EventArgs e)
        {
            if (txtMin.TextLength <= 0)
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Geçilemez!";
                lblControl.Visible = true;
                txtMin.Focus();
                txtMin.SelectAll();
            }
            else if (txtMin.TextLength <= 1) 
            {
                lblControl.Text = "";
                lblControl.Text = "Basamak Sayısı 2'den Büyük Olmalı";
                lblControl.Visible = true;
                txtMin.Focus();
                txtMin.SelectAll();
            }
            else
                lblControl.Visible = false;
        }

        private void txtUst_Leave(object sender, EventArgs e)
        {
            if (txtMax.TextLength <= 1)
            {
                lblControl.Text = "";
                lblControl.Text = "Basamak Sayısı 2'den Büyük Olmalı";
                lblControl.Visible = true;
                txtMax.Focus();
                txtMax.SelectAll();
            }
            else if (txtMax.TextLength <= 0)
            {
                lblControl.Text = "";
                lblControl.Text = "Boş Geçilemez!";
                lblControl.Visible = true;
                txtMax.Focus();
                txtMax.SelectAll();
            }
            else
                lblControl.Visible = false;
        }

        private void txtUst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtMin.Text.Equals("") && !txtMax.Text.Equals(""))
                {
                    if (int.Parse(txtMin.Text) > int.Parse(txtMax.Text))
                    {
                        DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                            HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMax.Text), int.Parse(txtMin.Text), listNumbers);
                        else
                            txtMin.Focus(); txtMin.SelectAll();
                    }
                    else
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMin.Text), int.Parse(txtMax.Text), listNumbers); lblControl.Visible = false;
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
                if (!txtMin.Text.Equals("") && !txtMax.Text.Equals(""))
                {
                    if (int.Parse(txtMin.Text) > int.Parse(txtMax.Text))
                    {
                        DialogResult result = MessageBox.Show("Alt sınırı üst sınırdan büyük girdiniz. Yer değiştirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                            HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMax.Text), int.Parse(txtMin.Text), listNumbers);
                        else
                            txtMin.Focus(); txtMin.SelectAll();
                    }
                    else
                        HelperArmStrongNumbers.ArmStrongControl(int.Parse(txtMin.Text), int.Parse(txtMax.Text), listNumbers); lblControl.Visible = false;
                }
                else
                {
                    lblControl.Text = "";
                    lblControl.Text = "Boş Alan Olmamalı!";
                    lblControl.Visible = true;
                }
            }
        }
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        #endregion
        #region FormControl

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulama Kapatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        private void FormCenter_Load(object sender, EventArgs e)
        {
            HelperMineField.DinamicButton(panelMines);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time.Enabled = false;
        }


        #region MineField

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((int)numbericMinesCount.Value < 25 && (int)numbericMinesCount.Value > 0)
            {
                HelperMineField.MineCreated((int)numbericMinesCount.Value, panelMines, (int)numbericTime.Value,time);
                time.Enabled = true;
                _FormPreview = new FormPreview();
                _FormPreview.Name = "form";
                if (Application.OpenForms["form"] == null)
                    _FormPreview.Show();
            }
            else
                MessageBox.Show("1-24 arasında değer girin!");
        }
        private void time_Tick(object sender, EventArgs e)
        {
            lblTotalTime.Text = "Kalan Süre = " + HelperMineField.Time.ToString();
            if (HelperMineField.Time == 0)
            {
                HelperMineField.GameRestart(panelMines,time);
                MessageBox.Show("Süre Bitti.\nYeniden başlayın!.", "Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            HelperMineField.Time--;
        }
        #endregion
    }
}
