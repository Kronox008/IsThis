﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class Randomizing
    {
        public static void Randomize()
        {
            Global.IsCorrectCount = 0; //reseting score


            System.Random randomnumber = new System.Random();

            List<int> galimi = Enumerable.Range(0, Global.Deckcounter).ToList();
            List<int> shuffledlistas = new List<int>();
            for (int i = 0; i < Global.QuestionQuantity; i++)
            {
                int index = randomnumber.Next(0, galimi.Count);
                shuffledlistas.Add(galimi[index]);
                galimi.RemoveAt(index);
            }

            Global.Numbers = shuffledlistas.ToArray();


        }
    }
}


//              List<int> possible = Enumerable.Range(0, (Global.Deckcounter - 1)).ToList();
//              List<int> listNumbers = new List<int>();
//               for (int i = 0; i<Global.QuestionQuantity; i++)
//                {
//                int index = rand.Next(0, possible.Count);
//                 listNumbers.Add(possible[index]);
//                possible.RemoveAt(index);
//                 }

//            Global.Numbers = listNumbers.ToArray();




            //Random random_number = new Random();
            //while (Shuffle(Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10))
            //{
            //    Num1 = random_number.Next(0, Global.Deckcounter);
            //}
            // while (Shuffle(Num2, Num1, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10))
            //{
            //    Num2 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num3, Num2, Num1, Num4, Num5, Num6, Num7, Num8, Num9, Num10))
            //{
            //    Num3 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num4, Num2, Num3, Num1, Num5, Num6, Num7, Num8, Num9, Num10))
            //{
            //    Num4 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num5, Num2, Num3, Num4, Num1, Num6, Num7, Num8, Num9, Num10))
            //{
            //    Num5 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num6, Num2, Num3, Num4, Num5, Num1, Num7, Num8, Num9, Num10))
            //{
            //    Num6 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num7, Num2, Num3, Num4, Num5, Num6, Num1, Num8, Num9, Num10))
            //{
            //    Num7 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num8, Num2, Num3, Num4, Num5, Num6, Num7, Num1, Num9, Num10))
            //{
            //    Num8 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num9, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num1, Num10))
            //{
            //    Num9 = random_number.Next(0, Global.Deckcounter);
            //}
            //while (Shuffle(Num10, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num1))
            //{
            //    Num10 = random_number.Next(0, Global.Deckcounter);
            //}
            //Global.Num1 = Num1;
            //Global.Num2 = Num2;
            //Global.Num3 = Num3;
            //Global.Num4 = Num4;
            //Global.Num5 = Num5;
            //Global.Num6 = Num6;
            //Global.Num7 = Num7;
            //Global.Num8 = Num8;
            //Global.Num9 = Num9;
            //Global.Num10 = Num10;




//    private static bool Shuffle(int Num1, int Num2, int Num3, int Num4, int Num5, int Num6, int Num7, int Num8, int Num9, int Num10)
//    {
//        if (Num1 == -1 || Num1 == Num2 || Num1 == Num3 || Num1 == Num4
//            || Num1 == Num5 || Num1 == Num6 || Num1 == Num7 || Num1 == Num8 || Num1 == Num9 || Num1 == Num10)
//        {
//            return true;
//        }

//        return false;
//    }
//}
//}
