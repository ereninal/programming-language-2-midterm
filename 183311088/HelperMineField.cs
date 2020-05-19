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
        private static List<Button> Mines = new List<Button>();
        protected static Button btn;
        public static void DinamicButton(Control control)
        {
            int ButtonCount = 1;
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    btn = new Button();
                    btn.Name = ButtonCount.ToString();
                    //btn.Text = ButtonCount.ToString();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.BackColor = Color.DimGray;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Location = new Point(14+(j*37),(i*37)+12);
                    btn.Click += Btn_Click;
                    control.Controls.Add(btn);
                    ButtonCount++;
                }
            }
            
        }
        private static void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }
        public static void MineCreatedPreview(int _count, Control control)
        {
            Random rnd = new Random();
            int ButonNumber,OldButonNumber=0;
            for (int i = 0; i < _count; i++)
            {
                ButonNumber = rnd.Next(1, 25);
                while (OldButonNumber == ButonNumber) { ButonNumber = ButonNumber == OldButonNumber ? rnd.Next(1, 24) : ButonNumber; }
                OldButonNumber = ButonNumber;
                Button _btn = control.Controls.Find(ButonNumber.ToString(), true).FirstOrDefault() as Button;
                _btn.BackColor = Color.Red;
                Mines.Add(_btn);
            }
            foreach (var item in Mines)
            {
                Button _btn = control.Controls.Find(item.Name.ToString(), true).FirstOrDefault() as Button;
                if ((Button)control.Controls[(int.Parse(_btn.Name) + 1)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) + 1)]))
                    {
                       Button btn = control.Controls.Find(Convert.ToInt32(item.Name+1).ToString(), true).FirstOrDefault() as Button;
                        btn.Text = "Y";
                    }
                    else { btn.Text = "0"; }
                    //tıklanılan yerin etrafı aranacak.
                }
            }
            //FindMine(control);
        }
        private static void FindMine(Control control)
        {
            Button[] MineCount = new Button[8];
            Button _btn;
            //Button _btn = control.Controls.Find(item.ToString(), true).FirstOrDefault() as Button;
            for (int i = 1; i <25; i++)
            {
                _btn = control.Controls.Find(i.ToString(), true).FirstOrDefault() as Button;
                
                if ((Button)control.Controls[(int.Parse(_btn.Name) + 1)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) + 1)]))
                    {
                        Mines[0] = (Button)control.Controls[(int.Parse(_btn.Name) + 1)];
                    }
                    else { Mines[0] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) - 1)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) - 1)]))
                    {
                        Mines[1] = (Button)control.Controls[(int.Parse(_btn.Name) - 1)];
                    }
                    else { Mines[1] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) - 5)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) - 5)]))
                    {
                        Mines[2] = (Button)control.Controls[(int.Parse(_btn.Name) - 5)];
                    }
                    else { Mines[2] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) + 5)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name)  +5)]))
                    {
                        Mines[3] = (Button)control.Controls[(int.Parse(_btn.Name) + 5)];
                    }
                    else { Mines[3] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) + 4)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) + 4)]))
                    {
                        Mines[4] = (Button)control.Controls[(int.Parse(_btn.Name) + 4)];
                    }
                    else { Mines[4] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Text) - 4)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) - 4)]))
                    {
                        Mines[5] = (Button)control.Controls[(int.Parse(_btn.Name) - 4)];
                    }
                    else { Mines[5] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) + 6)] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) + 6)]))
                    {
                        Mines[6] = (Button)control.Controls[(int.Parse(_btn.Name) + 6)];
                    }
                    else { Mines[6] = null; }
                }
                if ((Button)control.Controls[(int.Parse(_btn.Name) -6 )] != null)
                {
                    if (Mines.Contains((Button)control.Controls[(int.Parse(_btn.Name) -6)]))
                    {
                        Mines[7] = (Button)control.Controls[(int.Parse(_btn.Name) -6)];
                    }
                    else { Mines[7] = null; }
                }

            }
            for (int i = 0; i < Mines.Count; i++)
            {
                if (Mines[i] != null)
                    Mines[i].BackColor = Color.Red;
            }
        }
    }
}
