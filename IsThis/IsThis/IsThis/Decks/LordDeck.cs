using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class LordDeck
    {

        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {  { "Galadriel", "Galadriel.jpg" }  , { "Saruman the White", "Saruman_the_White.jpg" }  , { "Eomer", "Eomer.jpg" } 
                    , { "Theoden", "Theoden.jpg" }  , { "Eowyn", "Eowyn.jpg" }  , { "Grima Wormtongue", "Grima_Wormtongue.jpg" }    , { "Shadowfax", "Shadowfax.jpg" }  
                    , { "Treebeard", "Treebeard.jpg" }  , { "Shelob", "Shelob.jpg" }    , { "Faramir", "Faramir.jpg" }  , { "Denethor", "Denethor.jpg" }    , { "Balrog", "Balrog.jpg" }
                    , { "Frodo Baggins", "Frodo_Baggins.jpg" } , { "Gandalf the Grey", "Gandalf_the_Grey.jpg" }    , { "Sam", "Sam.jpg" }  , { "Merry", "Merry.jpg" }  , { "Pippin", "Pippin.jpg" } 
                    , { "Aragorn", "Aragorn.jpg" }  , { "Legolas", "Legolas.jpg" }  , { "Gimli", "Gimli.jpg" }  , { "Boromir", "Boromir.jpg" }  , { "Sauron", "Sauron.jpg" }  
                    , { "The Nazgul", "The_Nazgul.jpg" }    , { "Gollum", "Gollum.jpg" }    , { "Bilbo Baggins", "Bilbo_Baggins.jpg" }  , { "Elrond", "Elrond.jpg" } 
                    , { "Arwen Evenstar", "Arwen_Evenstar.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Lord of the Rings Deck";
                Global.DeckInfo = "deck info";
                Randomizing.Randomize(allQuestions_in_orderEN);


                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i], 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i], 1];
                //}
            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                 { "Galandrielė", "Galadriel.jpg" }  , { "Sarumanas Baltasis", "Saruman_the_White.jpg" } , { "Eomeras", "Eomer.jpg" }    , { "Theodenas", "Theoden.jpg" }    
                    , { "Eovyna", "Eowyn.jpg" } , { "Grima Sliužburnis", "Grima_Wormtongue.jpg" }   , { "Žvaigždikis", "Shadowfax.jpg" }    , { "Medžiabarzdis", "Treebeard.jpg" } 
                    , { "Šeloba", "Shelob.jpg" }    , { "Faramiras", "Faramir.jpg" }    , { "Denetoras", "Denethor.jpg" }   , { "Balgoras", "Balrog.jpg" } , 
                 { "Frodas Beginsas", "Frodo_Baggins.jpg" } , { "Gendalfas Pilkasis", "Gandalf_the_Grey.jpg" }  , { "Semas", "Sam.jpg" }    , { "Meris", "Merry.jpg" }
                    , { "Pipinas", "Pippin.jpg" }   , { "Aragornas", "Aragorn.jpg" }    , { "Legolasas", "Legolas.jpg" }    , { "Gimlis", "Gimli.jpg" } , 
                 { "Boromiras", "Boromir.jpg" }    , { "Sauronas", "Sauron.jpg" }  , { "Nazgulai", "The_Nazgul.jpg" }  , { "Golumas", "Gollum.jpg" }   ,
                 { "Bilbas Beginsas", "Bilbo_Baggins.jpg" }    , { "Elroldas", "Elrond.jpg" }  , { "Arvena", "Arwen_Evenstar.jpg" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Žiedų valdovo kaladė";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
