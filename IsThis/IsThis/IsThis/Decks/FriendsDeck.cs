using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    public class FriendsDeck
    {
        public static void SetDeckInfo()
        {
            if(Global.LanguageSelectedID == 0)
            { 
            string[ , ] allQuestions_in_orderEN = { { "Gunther", "Gunther.jpg" }, { "Jack Geller", "jack_geller.jpg"}, {"Ursula Buffay", "Ursula_Buffay.jpg"},
            { "Marcel","marcel.jpg" }, {"Paolo", "Paolo.jpg"}, {"David", "David.jpg"}, {"Julie","Julie.jpg" }, {"Estelle Leonard","Estelle_Leonard.jpg" },
            {"Mike Hannigan","Mike_Hannigan.jpg" },  {"Janine LaCroix", "Janine_LaCroix.jpg" }, { "Judy Geller", "Judy_Geller.jpg" },  
            { "Barry Farber", "Barry_Farber.jpg" }, { "Carol Willick", "Carol_Willick.jpg" },   { "Susan Bunch", "Susan_Bunch.jpg" },  
            { "Janice Litman Goralnik", "Janice_Litman_Goralnik.jpg" }, { "Mr. Heckles", "Mr_Heckles.jpg" },    { "Nora Tyler Bing", "Nora_Tyler_Bing.jpg" },
            { "Steve", "Steve.jpg" },   { "Mr. Treeger", "Mr_Treeger.jpg" },    { "Dr. Richard Burke", "Dr_Richard_Burke.jpg" },    
            { "Frank Buffay Jr.", "Frank_Buffay_Jr.jpg" },  { "Leonard Green", "Leonard_Green.jpg" },   { "Sandra Green", "Sandra_Green.jpg" }, 
            { "Eddie Manoick", "Eddie_Manoick.jpg" },   { "Mark Robinson", "Mark_Robinson.jpg" },   { "Sophie", "Sophie.jpg" }, { "Phoebe Abbott", "Phoebe_Abbott.jpg" },
            { "Pete Becker", "Pete_Becker.jpg" },   { "Alice Knight Buffay", "Alice_Knight_Buffay.jpg" },   { "Kathy", "Kathy.jpg" },  
            { "Emily Waltham", "Emily_Waltham.jpg" },   { "Joshua Burgin", "Joshua_Burgin.jpg" },   { "Mr. Zelner", "Mr_Zelner.jpg" },  { "Gary", "Gary.jpg" },
            { "Elizabeth Stevens", "Elizabeth_Stevens.jpg" },   { "Jill Green", "Jill_Green.jpg" }, { "Tag Jones", "Tag_Jones.jpg" },   { "Mona", "Mona.jpg" },
            { "Dr. Long", "Dr_Long.jpg" },  { "Amy Green", "Amy_Green.jpg" },   { "Charlie Wheeler", "Charlie_Wheeler.jpg" },   { "Erica", "Erica.jpg" }, { "Smelly Cat", "Smelly_Cat.jpg" },
            { "Unagi", "Unagi.jpg" },   { "Red Ross", "Red_Ross.jpg" }, { "Yemen", "Yemen.jpg" },   { "Armadillo", "Armadillo.jpg" },   { "In Prison!", "In_Prison.jpg" },  { "Wah! Pah!", "Wah_Pah.jpg" },
            { "Central Perk", "Central_Perk.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length)/2;



                Global.Deckcounter = countEN;
                Global.DeckName = "F.R.I.E.N.D.S Deck";
                Global.DeckInfo = "deck info supposed to be here.......";
                Randomizing.Randomize();
           

                for (int i = 0; i < Global.QuestionQuantity; i++)
                {
                    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i], 0];
                    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i], 1];
                }
            }
            else
            {
                string[,] allQuestions_in_orderLT = { { "Gunther", "Gunther.jpg" }, { "Jack Geller", "jack_geller.jpg"}, {"Ursula Buffay", "Ursula_Buffay.jpg"},
            { "Marcel","marcel.jpg" }, {"Paolo", "Paolo.jpg"}, {"David", "David.jpg"}, {"Julie","Julie.jpg" }, {"Estelle Leonard","Estelle_Leonard.jpg" },
            {"Mike Hannigan","Mike_Hannigan.jpg" },  {"Janine LaCroix", "Janine_LaCroix.jpg" }, { "Judy Geller", "Judy_Geller.jpg" },
            { "Barry Farber", "Barry_Farber.jpg" }, { "Carol Willick", "Carol_Willick.jpg" },   { "Susan Bunch", "Susan_Bunch.jpg" },
            { "Janice Litman Goralnik", "Janice_Litman_Goralnik.jpg" }, { "Mr. Heckles", "Mr_Heckles.jpg" },    { "Nora Tyler Bing", "Nora_Tyler_Bing.jpg" },
            { "Steve", "Steve.jpg" },   { "Mr. Treeger", "Mr_Treeger.jpg" },    { "Dr. Richard Burke", "Dr_Richard_Burke.jpg" },
            { "Frank Buffay Jr.", "Frank_Buffay_Jr.jpg" },  { "Leonard Green", "Leonard_Green.jpg" },   { "Sandra Green", "Sandra_Green.jpg" },
            { "Eddie Manoick", "Eddie_Manoick.jpg" },   { "Mark Robinson", "Mark_Robinson.jpg" },   { "Sophie", "Sophie.jpg" }, { "Phoebe Abbott", "Phoebe_Abbott.jpg" },
            { "Pete Becker", "Pete_Becker.jpg" },   { "Alice Knight Buffay", "Alice_Knight_Buffay.jpg" },   { "Kathy", "Kathy.jpg" },
            { "Emily Waltham", "Emily_Waltham.jpg" },   { "Joshua Burgin", "Joshua_Burgin.jpg" },   { "Mr. Zelner", "Mr_Zelner.jpg" },  { "Gary", "Gary.jpg" },
            { "Elizabeth Stevens", "Elizabeth_Stevens.jpg" },   { "Jill Green", "Jill_Green.jpg" }, { "Tag Jones", "Tag_Jones.jpg" },   { "Mona", "Mona.jpg" },
            { "Dr. Long", "Dr_Long.jpg" },  { "Amy Green", "Amy_Green.jpg" },   { "Charlie Wheeler", "Charlie_Wheeler.jpg" },   { "Erica", "Erica.jpg" }, { "Smelly Cat", "Smelly_Cat.jpg" },
            { "Unagi", "Unagi.jpg" },   { "Red Ross", "Red_Ross.jpg" }, { "Yemen", "Yemen.jpg" },   { "Armadillo", "Armadillo.jpg" },   { "In Prison!", "In_Prison.jpg" },  { "Wah! Pah!", "Wah_Pah.jpg" },
            { "Central Perk", "Central_Perk.jpg" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "D.R.A.U.G.A.I kaladė";
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
