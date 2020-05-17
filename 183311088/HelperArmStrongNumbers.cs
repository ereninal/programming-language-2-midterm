using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _183311088
{
    public class HelperArmStrongNumbers
    {
        private static bool Armstrong(string _number)
        {
            bool state = false;
            char[] ArrayNumber = _number.ToCharArray();
            int NumberLength = _number.Length;
            int Number = Convert.ToInt32(_number);
            int TotalArray = 1, Total = 0; ;
            for (int i = 0; i < NumberLength; i++)
            {
                for (int j = 0; j < NumberLength; j++)
                {
                    TotalArray *= Convert.ToInt32(ArrayNumber[i].ToString());
                }
                Total += TotalArray;
                TotalArray = 1;
            }
            state = _number == Total.ToString() ? !state : state;
            return state;
        }
        public static void ArmStrongControl(int min,int max, ListBox list)
        {
            list.Items.Clear();
            for (int i =min; i <= max; i++)
            {
                if (Armstrong(i.ToString()))
                {
                    list.Items.Add(i.ToString());
                }
            }
            if (list.Items.Count < 1)
                list.Items.Add("Armstrong Yok");
        }
       
       
    }
}
