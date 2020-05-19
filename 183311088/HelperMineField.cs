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
            
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    btn = new Button();
                    btn.Name = (j + 1).ToString();
                    btn.Text = (j + 1).ToString();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.BackColor = Color.DimGray;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Location = new Point(14+(j*37),(i*37)+12);
                    btn.Click += Btn_Click;
                    control.Controls.Add(btn); 
                }
            }
            
        }
        private static void Btn_Click(object sender, EventArgs e)
        {
            //TODO: Dinamik buyonları kontrol et.
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name.ToString());
            btn.BackColor = Color.Red;
        }
        public static void MineCreated(int _count, Control control)
        {
            Random rnd = new Random();
            int ButonNumber,OldButonNumber=0;
            
            Button _btn =control.Controls.Find("button1", true).FirstOrDefault() as Button;
            
            
                
            /*for (int i = 0; i < _count; i++)
            {
                ButonNumber = rnd.Next(1, 24);
                
                //ButonNumber = ButonNumber == OldButonNumber ? rnd.Next(1, 24) : OldButonNumber = ButonNumber;
                
            }*/
        }
    }
}
