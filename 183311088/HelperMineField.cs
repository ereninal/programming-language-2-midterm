using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _183311088
{
    public class HelperMineField
    {
        protected static Button btn;
        public static void DinamicButton(Control control)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btn = new Button();
                    btn.Name = i.ToString();
                    btn.Text = i.ToString();
                    btn.Width = 80;
                    btn.Height = 50;
                    btn.Click += Btn_Click;
                    control.Controls.Add(btn); //oluşan butonlar üstüste binmez
                }
            }
            
        }
        private static void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }
    }
}
