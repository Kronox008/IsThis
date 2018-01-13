using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class HarryDeck
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {  { "Minerva McGonagall", "Minerva_McGonagall.jpg" }  , { "Dolores Umbridge", "Dolores_Umbridge.jpg" }
                    , { "Lucius Malfoy", "Lucius_Malfoy.jpg" }  , { "Remus Lupin", "Remus_Lupin.jpg" }  , { "Rubeus Hagrid", "Rubeus_Hagrid.jpg" }  , 
                    { "Luna Lovegood", "Luna_Lovegood.jpg" }  , { "Bellatrix Lestrange", "Bellatrix_Lestrange.jpg" }  , { "Draco Malfoy", "Draco_Malfoy.jpg" }
                    , { "Sirius Black", "Sirius_Black.jpg" }    , { "Voldemort", "Voldemort.jpg" }  , { "Neville Longbottom", "Neville_Longbottom.jpg" }    ,
                    { "Albus Dumbledore", "Albus_Dumbledore.jpg" }    , { "Severus Snape", "Severus_Snape.jpg" }  , { "Ron Weasley", "Ron_Weasley.jpg" }  ,
                    { "Hermione Granger", "Hermione_Granger.jpg" }    , { "Harry Potter", "Harry_Potter.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Harry Potter deck";
                Global.DeckInfo = "deck info";
                Randomizing.Randomize();


                for (int i = 0; i < Global.QuestionQuantity; i++)
                {
                    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i], 0];
                    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i], 1];
                }
            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                    { "Džiudi Geler", "Judy_Geller.jpg" } 

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Hario Poterio kaladė";
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

