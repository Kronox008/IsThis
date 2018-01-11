using Plugin.SimpleAudioPlayer.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis
{
    public static class Global
    { 
        public static int DeckNumber { get; set;  }        // which one deck selected
        public static string DeckName { get; set; }       //  selected deck name
        public static string DeckInfo { get; set; }      //   information what is in this deck
        public static int Deckcounter { get; set; }     //    how many records in deck
        public static string DeckPoster { get; set;}   //     deck poster string


        //Numbers for Questions to be selected
        public static int Num1  { get; set; }
        public static int Num2  { get; set; }
        public static int Num3  { get; set; }
        public static int Num4  { get; set; }
        public static int Num5  { get; set; }
        public static int Num6  { get; set; }
        public static int Num7  { get; set; }
        public static int Num8  { get; set; }
        public static int Num9  { get; set; }
        public static int Num10 { get; set; }

        //----Question quantity--------------------------------------------------------------------------------------------------
        public static int QuestionQuantity { get; set; }

        //Array to hold questions
        public static string[ , ] ShuffledQuestion = new string[50, 2];

        //Array to hold correct or not
        public static int[] IsCorrect = new int[50];
        public static int[] IsGuessed = new int[50];
        public static int IsCorrectCount { get; set; }


        //Timer------------------------------------------------------------------------------------------
        public static int CountDownTimeIsOn { get; set; }
        public static int CountDownTime { get; set; }

        
        //-------colors-----------------------------------------------------------------------------------------
 
        public static string SkipColorHex = "#ff0033";
        public static string CorrectColorHex = "#50c878";
        public static string ButtonTextColor = "#090f0f";
        public static string ButtonTextWhiteColor = "#ececec";
        public static string ButtonBackColor = "#d35400";

       




    }


}

                    