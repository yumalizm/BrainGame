using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 課題
{
    //３手目まで回ってきた場合考えうる場合は
    //0,1,0か0,1,2のいずれかである

    class _3teme
    {
        int[] box3 = new int[3];
        int changeBoxNumber, afterNumber;
        int emptybox1, emptybox2 = 100;
        bool win = false;

        public _3teme(int[] a)
        {
            box3 = a;
        }

        public void yuma1()
        {
            //空の箱がどの箱か調べる

            for (int i = 0; i < 3; i++)
            {
                if (box3[i] == 0)
                {
                    emptybox1 = i;
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (box3[i] == 0 && i != emptybox1)
                {
                    emptybox2 = i;
                    break;
                }
            }
        }

        public void yuma2()
        {
            //もし空の箱が1個の場合
            if (emptybox2 == 100)
            {
                for (int i = 0; i < 3; i++)
                {

                    if (box3[i] == 2)
                    {
                        changeBoxNumber = i;
                        afterNumber = 0;
                        box3[changeBoxNumber] = afterNumber;
                    }
                }
            }
            else //空の箱が2個のとき(＝CPの負け)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (box3[i] == 1)
                    {
                        changeBoxNumber = i;
                        afterNumber = 0;
                        box3[changeBoxNumber] = afterNumber;
                        win = true;
                    }
                }
            }
        }

        public int[] yuma3()
        {
            return box3;
        }

        public bool yuma4()
        {
            return win;
        }



    }
}
