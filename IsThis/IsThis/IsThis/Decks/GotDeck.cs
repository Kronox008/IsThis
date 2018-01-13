using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class GotDeck
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            { 
                string[,] allQuestions_in_orderEN = { { "Eddard (Ned) Stark", "Ned_Stark.jpg" }, { "Jaime Lannister", "Jaime_Lannister.jpg"}, {"Sansa Stark", "Sansa_Stark.jpg"},
                 { "Khal Drogo","Khal_Drogo.jpg" }, {"Bronn", "Bronn.jpg"}, {"Shae", "Shae.jpg"},
                 {"Gilly","Gilly.jpg" }, {"Missandei","Missandei.jpg" }, {"Roose Bolton","Roose_Bolton.jpg" }, {"The High Sparrow", "The_High_Sparrow.jpg" },{"	Margaery Tyrell","Margaery_Tyrell.jpg	"} };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Game of Thrones";
                Global.DeckInfo = "Game Of Thrones characters, quotes, cities, places.";
                Randomizing.Randomize();
                //Name
                for (int i = 0; i < Global.QuestionQuantity; i++)
                {
                    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i] , 0];
                    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i] , 1];
                }

            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                   { "Edardas (Nedas) Starkas", "Ned_Stark.jpg" }, { "Džeimis Lanisteris", "Jaime_Lannister.jpg" }  , { "Sansa Stark", "Sansa_Stark.jpg" }  , { "Khalas Drogo", "Khal_Drogo.jpg" } 
                    , { "Bronas", "Bronn.jpg" } , { "Šėja", "Shae.jpg" }    , { "Gilė", "Gilly.jpg" }   , { "Misandėja", "Missandei.jpg" }  , { "Rusas Boltonas", "Roose_Bolton.jpg" }  
                    , { "Vyriausiasis žvirblis", "The_High_Sparrow.jpg" }   , { "Mardžeri Tairel", "Margaery_Tyrell.jpg" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Sostų karai";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize();


                for (int i = 0; i < Global.QuestionQuantity; i++)
                {
                    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderLT[Global.Numbers[i], 0];
                    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderLT[Global.Numbers[i], 1];
                }
            }
        }
    }
}