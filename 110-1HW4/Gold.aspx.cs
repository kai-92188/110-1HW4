using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW4
{
    public partial class Gold : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_X = 7;
            int i_Input = i_X;
            if (i_X < 9)
            {
                i_X = 8;
            }
            int[] ia_Arr = new int[(i_X + 1)];
            mt_Ini(ref ia_Arr);
            mt_Recur(ref ia_Arr, i_X);
            Response.Write(ia_Arr[i_Input]);
        }

        public void mt_Ini(ref int[] ia_Arr)
        {
            for (int i_Ct = 0; i_Ct < ia_Arr.Length; i_Ct++)
            {
                ia_Arr[i_Ct] = 0;
            }
            ia_Arr[1] = 2;
            ia_Arr[2] = 5;
            ia_Arr[3] = 9;
            ia_Arr[4] = 10;
            ia_Arr[5] = 15;
            ia_Arr[6] = 16;
            ia_Arr[7] = 19;
            ia_Arr[8] = 26;
        }

        public void mt_Pri(ref int[] ia_Arr)
        {
            for (int i_Ct = 0; i_Ct < ia_Arr.Length; i_Ct++)
            {
                Response.Write(ia_Arr[i_Ct]);
                Response.Write("/t");
            }
        }

        public void mt_Recur(ref int[] ia_Arr, int i_X)
        {
            if (i_X <= 1)
            {
                return;
            }
            mt_Recur(ref ia_Arr, i_X - 1);
            int i_Max = ia_Arr[i_X];
            for (int i_Ct = 1; i_Ct <= i_X / 2; i_Ct++)
            {
                int i_Sum = ia_Arr[i_Ct] + ia_Arr[i_X - i_Ct];
                if (i_Sum > i_Max)
                {
                    i_Max = i_Sum;
                }
            }
            ia_Arr[i_X] = i_Max;
        }
    }
}