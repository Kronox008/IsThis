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
                    { "Hermione Granger", "Hermione_Granger.jpg" }    , { "Harry Potter", "Harry_Potter.jpg" } , { "Dobby", "Dobby.jpg" } 
                    , { "Ginny Weasley", "Ginny_Weasley.jpg" }  , { "Gilderoy Lockhart", "Gilderoy_Lockhart.jpg" }  , { "Horace Slughorn", "Horace_Slughorn.jpg" }
                    , { "Molly Weasley", "Molly_Weasley.jpg" }  , { "Alastor Moody", "Alastor_Moody.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Harry Potter deck";
                Global.DeckInfo = "deck info";
                Randomizing.Randomize(allQuestions_in_orderEN);
                
            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                 { "Minerva Makonagal", "Minerva_McGonagall.jpg" } , { "Dolores Umbridž", "Dolores_Umbridge.jpg" } , { "Liucijus Smirdžius", "Lucius_Malfoy.jpg" } 
                    , { "Remas Lupinas", "Remus_Lupin.jpg" }    , { "Rubijus Hagridas", "Rubeus_Hagrid.jpg" }   , { "Luna Geranorė", "Luna_Lovegood.jpg" }  ,
                 { "Belatriks Lestreindž", "Bellatrix_Lestrange.jpg" } , { "Drakas Smirdžius", "Draco_Malfoy.jpg" }    , { "Sirijus Blackas", "Sirius_Black.jpg" }
                    , { "Voldemortas", "Voldemort.jpg" }    , { "Nevilis Nevėkšla", "Neville_Longbottom.jpg" }  , { "Albas Dumbldoras", "Albus_Dumbledore.jpg" }  
                    , { "Severas Sneipas", "Severus_Snape.jpg" }    , { "Ronas Vizlis", "Ron_Weasley.jpg" } , { "Hermiona Įkyrelė", "Hermione_Granger.jpg" }    
                    , { "Haris Poteris", "Harry_Potter.jpg" } , { "Dobis", "Dobby.jpg" }    , { "Džinė Vizli", "Ginny_Weasley.jpg" }   
                    , { "Gilderojus Lokhartas", "Gilderoy_Lockhart.jpg" }   , { "Horacijus", "Horace_Slughorn.jpg" }    , { "Molė Vizli", "Molly_Weasley.jpg" } 
                    , { "Alastoras Mudis", "Alastor_Moody.jpg" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Hario Poterio kaladė";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);


                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderLT[Global.Numbers[i], 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderLT[Global.Numbers[i], 1];
                //}
            }
        }

    }
}

