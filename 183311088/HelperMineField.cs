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
        #region Types

        private static List<int> Mines = new List<int>();
        static FormCenter FormCenter = new FormCenter();
        static FormPreview FormPreview = new FormPreview();
        private static Control Control;
        protected static Button btn;
        private static Timer Timer;
        public static int _Time;
        private static int OldTime;
        private static int Winner;
        private static int GreenButtonCount = 0;

        #endregion
        #region Properties

        public static int Time { get { return _Time; } set { _Time = value; } }
        static int MinesCount
        {
            get { return Mines.Count; }
        }
        #endregion
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
            if (MinesCount != 0)
            {
                FormCenter.lblTotalTime.Text = "Kalan Süre = " + OldTime.ToString();
                Time = OldTime;
                Button btn = (Button)sender;
                if (MineFine(int.Parse(btn.Name)))
                {
                    btn.BackColor = Color.Red;
                    HelperMineField.GameRestart(Control,Timer);
                    MessageBox.Show("Oyun Bitti.\nYeniden Başlayın");
                }
                else
                {
                    int s = MineCountButton(btn);
                    btn.Text = s.ToString();
                    btn.BackColor = Color.Green;
                    GreenButtonCount++;
                    if (Winner == GreenButtonCount)
                    {
                        MessageBox.Show("Tebrikler\nYeniden başlamak için 'Başla' butonuna basın!");
                        GameRestart(Control, Timer);
                    }
                }
            }
            else
            {
                MessageBox.Show("Oyun Başlamadı.");
            }
        }
        public static void GameRestart(Control control,Timer timer)
        {
            
            Mines.Clear();
            timer.Enabled = false;
            FormCenter.time.Stop();
            foreach  (Button button in Control.Controls)
            {
                button.Text = "";
                button.BackColor = Color.DimGray;
            }
        }
        public static void MineCreated(int sayi, Control control, int time,Timer timer)
        {
            Timer = timer;
            OldTime = time;
            _Time = time;
            Control = control;
            if (MinesCount == 0)
            {
                MineInsert(sayi);
                Winner = 25 - MinesCount;
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
                    MinePreview(FormPreview.panelMine);
                    DinamicButton(FormPreview.panelMine);
                }
            }
        }
        public static void MinePreview(Control control)
        {
            int number;
            foreach (Button item in control.Controls)
            {
                Button button = (Button)control.Controls.Find((int.Parse(item.Name)).ToString(), false).FirstOrDefault();
                number = MineCountButton(button);
                item.Click += null;
                item.Text = number.ToString();
                if (MineFine(Convert.ToInt32(item.Name)))
                {
                    item.BackColor = Color.Red;
                    item.Text = "";
                }
                else
                {
                    item.BackColor = Color.Green;
                }
            }
            
        }
        private static void MineInsert(int count)
        {
            Random rnd = new Random();
            int ButonNumber;
            for (int i = 0; i < count; i++)
            {
                ButonNumber = rnd.Next(1, 25);
                while (MineFine(ButonNumber)) { ButonNumber = rnd.Next(1, 24); }
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
            int count = 0;
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 1).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 1))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 1).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 1))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) +5).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 5))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 5).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 5))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 6).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) + 6))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 6).ToString(), true).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 6))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) - 4).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) - 4))
                {
                    count++;
                }
            }
            if ((Button)Control.Controls.Find((int.Parse(button.Name) + 4).ToString(), false).FirstOrDefault() != null)
            {
                if (MineFine(int.Parse(button.Name) +4))
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
