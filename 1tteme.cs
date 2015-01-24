using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題
{
    class _1tteme
    {
        int[] box1 = new int[3];
        int changeBoxNumber,afternumber;


        public _1tteme(int[] a)
        {
            box1 = a;
        }

        public void yuma1()
        {
            for (int i = 0; i < 3; i++)
            {
                if (box1[i] != 3)
                {
                    switch (box1[i])
                    {
                        //一個が0個のときに、残り二つのどちらかを二つにする(CPが負けるパターン）
                        case 0:
                            afternumber = 2;
                            changeBoxNumber = 0;
                            if (changeBoxNumber == i)
                                changeBoxNumber = 1;
                            box1[changeBoxNumber] = afternumber;
                            i = 3;
                            break;
                        //一個が１個のとき、その箱を空にする。
                        case 1:
                            afternumber = 0;
                            changeBoxNumber = i;
                            box1[changeBoxNumber] = afternumber;
                            break;
                        //一個が二個のとき、その箱を空にする。
                        case 2:
                            afternumber = 0;
                            changeBoxNumber = i;
                            box1[changeBoxNumber] = afternumber;
                            break;
                    }
                }
            }
        }

        public int[] yuma2()
        {
            return box1;
        }
        


    }
}
