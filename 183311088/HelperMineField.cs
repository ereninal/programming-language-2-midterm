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
                    btn.Name = (i*j+1).ToString();
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
            btn.BackColor = Color.Red;
        }
        public static void MineCreated(int _count)
        {
            Random rnd = new Random();
            for (int i = 0; i < _count; i++)
            {

            }
        }
    }
}
