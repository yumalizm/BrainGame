using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 課題
{
    
    //二手目のときは必ず一個は空になっている状態

    class _2teme
    {
        int[] box2 = new int[3];
        int changeBoxNumber, afterNumber;
        int emptybox1,emptybox2=100;
        int lestbox1,lestbox2=100;

        public _2teme(int[] a)
        {
            box2 = a;
        }

        public void yuma1()
        {
            //空の箱が何個あるか調べる
            for (int i = 0; i < 3; i++)
            {
                if (box2[i] == 0)
                {
                    emptybox1 = i;
                    i = 3;

                }
                
                
            }

            
            //もし二つ空の箱があった場合
            for (int i = 0; i < 3; i++)
            {
                if (box2[i] == 0 && emptybox1 != i)
                {
                    emptybox2 = i;
                    i = 3;
                }
                else
                    emptybox2 = 100;
            }
        }

        public void yuma2()
        {
            //もし二つの箱が空の場合
            if (emptybox2 !=100)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i != emptybox1 && i != emptybox2)
                        changeBoxNumber = i;
                }
                afterNumber = 1;
                box2[changeBoxNumber] = afterNumber;
            }

            //もし空の箱が一つだけの場合
            if (emptybox2 == 100)
            {

                //残りの箱のどちらか片方が３つの場合
                for (int i = 0; i < 3; i++)
                {
                    if (box2[i] != 0 && box2[i] != 3)
                        lestbox1 = i;
                    if (box2[i] == 3)
                        lestbox2 = i;
                }

                if (lestbox2 != 100 )
                {
                    switch (box2[lestbox1])
                    {
                        case 1:
                            changeBoxNumber = lestbox2;
                            afterNumber = 0;
                            box2[changeBoxNumber] = afterNumber;
                            break;
                        case 2:
                            changeBoxNumber = lestbox2;
                            afterNumber = 2;
                            box2[changeBoxNumber] = afterNumber;
                            break;
                    }
                }
                else if(lestbox2 == 100)
                {

                    //残りの箱が２個、n(n=1,2)個のとき
                    for (int i = 0; i < 3; i++)
                    {
                        if (box2[i] == 2)
                        {
                            lestbox1 = i;
                            goto jump2;
                        }
                    }

                jump2:
                    //n個の箱の番号を確認
                    for (int i = 0; i < 3; i++)
                    {
                        if (i != lestbox1 && i != emptybox1)
                            lestbox2 = i;
                    }

                    //n個の玉が入っている箱の処理
                    switch (box2[lestbox2])
                    {
                        case 1:
                            changeBoxNumber = lestbox1;
                            afterNumber = 0;
                            box2[changeBoxNumber] = afterNumber;
                            break;
                        case 2: //CPが負ける手
                            changeBoxNumber = lestbox1;
                            afterNumber = 0;
                            box2[changeBoxNumber] = afterNumber;
                            break;
                    }
                }
            }
        }

        public int[] yuma3()
        {
            return box2;
        }






                










    }
}
