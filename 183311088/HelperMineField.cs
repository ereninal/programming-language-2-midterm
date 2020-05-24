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
        
        private static List<int> Mines = new List<int>();
        private static Control Control;
        protected static Button btn;
        static bool MineUp,Look;
        
        static int MayinSayisi
        {
            get { return Mines.Count; }
        }
        #region DinamicButton

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
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.Location = new Point(14+(j*37),(i*37)+12);
                    btn.Click += Btn_Click;
                    control.Controls.Add(btn);
                    ButtonCount++;
                }
            }
            
        }
        #endregion
        private static void Btn_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (MineFine(int.Parse(btn.Name)))
            {
                btn.BackColor = Color.Red;
                MessageBox.Show("Oyun Bitti");
            }
            else
            {
                int s = MineCountButton(btn);
                btn.Text = s.ToString();
                btn.BackColor = Color.Green;
            }
        }
        public static void MineCreated(int sayi, Control control)
        {
            
            Control = control;
            if (MayinSayisi == 0)
            {
                MineInsert(sayi);
            }
            else
            {
                DialogResult result = MessageBox.Show("Oyun yeniden başlatılsın mı?","UYARI",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Mines.Clear();
                    control.Controls.Clear();
                    DinamicButton(control);
                    MineInsert(sayi);
                    

                }
            }
        }
        private static void MineInsert(int count)
        {
            Random rnd = new Random();
            int ButonNumber, OldButonNumber = 0;
            for (int i = 0; i < count; i++)
            {
                ButonNumber = rnd.Next(1, 25);
                while (OldButonNumber == ButonNumber) { ButonNumber = ButonNumber == OldButonNumber ? rnd.Next(1, 24) : ButonNumber; }
                OldButonNumber = ButonNumber;
                Mines.Add(ButonNumber);
            }
        }
        private static bool MineFine(int m)
        {
            bool durum = false;
            foreach(var mayin in Mines)
            {
                if (Mines.Contains(m))
                {
                    durum=true;
                }
            }
            return durum;
        }
        private static int MineCountButton(Button button)
        {
            int sayi = 0;
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 1).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 1))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 1).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 1))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) +5).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 5))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 5).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 5))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 6).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 6))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 6).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 6))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 4).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 4))
                {
                    sayi++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 4).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) +4))
                {
                    sayi++;
                }
            }
            return sayi;
        }
        
    }
}
