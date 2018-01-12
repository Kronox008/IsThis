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
        public static int DeckNumber { get; set; }        // which one deck selected
        public static string DeckName { get; set; }       //  selected deck name
        public static string DeckInfo { get; set; }      //   information what is in this deck
        public static int Deckcounter { get; set; }     //    how many records in deck
        public static string DeckPoster { get; set; }   //     deck poster string




        //Numbers for Questions to be selected
        public static int[] Numbers = new int[50];

        //----Question quantity--------------------------------------------------------------------------------------------------
        public static int QuestionQuantity { get; set; }

        //Array to hold questions
        public static List<string> ShuffledQuestionList = new List<string>();
        public static string[,] ShuffledQuestion = new string[50, 2];

        //Array to hold correct or not
        public static int[] IsCorrect = new int[50];
        public static int[] IsGuessed = new int[50];
        public static int IsCorrectCount { get; set; }


        //Timer------------------------------------------------------------------------------------------

        public static int CountDownTime { get; set; }


        //-------colors-----------------------------------------------------------------------------------------

        public static string SkipColorHex = "#ff0033";
        public static string CorrectColorHex = "#50c878";
        public static string ButtonTextColor = "#090f0f";
        public static string ButtonTextWhiteColor = "#ececec";
        public static string ButtonBackColor = "#d35400";


        //--------------Languages?-----------------------------------------------------------------------------
        public static int LanguageSelectedID { get; set; }

        public static string SettingsButtonText { get; set; }
        public static string InfoButtonText { get; set; }
        public static string PlayButtonText { get; set; }
        public static string QuestionslabelText { get; set; }
        public static string HowToLabeltitle { get; set; }
        public static string HowToLabeltext { get; set; }
        public static string ScoreLabeltext { get; set; }



        public static void EN(int langID)
        { if(langID == 0)
            {

                SettingsButtonText = "Settings";
                InfoButtonText = "How to Play";
                PlayButtonText = "Play";
                QuestionslabelText = "questions";
                HowToLabeltitle = " Game 1:";
                HowToLabeltext = "English explanation";
                ScoreLabeltext = "Score: ";

            }
            else
            {
                SettingsButtonText = "Nustatymai";
                InfoButtonText = "Kaip žaisti?";
                PlayButtonText = "Pradėti";
                QuestionslabelText = "klausimų";
                HowToLabeltitle = " 1 variantas:";
                HowToLabeltext = "Telefona laikyk prieš save. Aiškinantis žaidėjas/komanda bandys tau padėti atspėti, koks gi žmogus/personažas/įvykis/vieta/citata šįkart įsitaisius tavo telefone! (Klausimai keičiami spaudžiant garsinimo / tildymo mygtukus ar mygtukus ekrane.";
                ScoreLabeltext = "Taškai: ";
            }

        }








    }


}

                    