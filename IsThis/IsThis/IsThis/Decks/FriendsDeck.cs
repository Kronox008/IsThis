using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
     class FriendsDeck
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
            { "Dr. Long", "Dr_Long.jpg" },  { "Amy Green", "Amy_Green.jpg" },   { "Charlie Wheeler", "Charlie_Wheeler.jpg" },   { "Erica", "Erica.jpg" },
            { "Smelly Cat", "Smelly_Cat.jpg" }, { "Unagi", "Unagi.jpg" },   { "Red Ross", "Red_Ross.jpg" }, { "Yemen", "Yemen.jpg" },  
            { "Armadillo", "Armadillo.jpg" },   { "In Prison!", "In_Prison.jpg" },  { "Wah! Pah!", "Wah_Pah.jpg" },
            { "Central Perk", "Central_Perk.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length)/2;



                Global.Deckcounter = countEN;
                Global.DeckName = "F.R.I.E.N.D.S Deck";
                Global.DeckInfo = "deck info supposed to be here.......";
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

                    { "Džiudi Geler", "Judy_Geller.jpg" } , { "Baris Faberis", "Barry_Farber.jpg" }   , { "Kerol Vilik", "Carol_Willick.jpg" }    
                    , { "Siuzan Bunč", "Susan_Bunch.jpg" }  , { "Dženis Litman Goralnik", "Janice_Litman_Goralnik.jpg" }    , { "Ponas Heklsas", "Mr_Heckles.jpg" }
                    , { "Nora Tailer Bing", "Nora_Tyler_Bing.jpg" } , { "Styvas", "Steve.jpg" } , { "Ponas Trigeris", "Mr_Treeger.jpg" } ,
                    { "Ričardas Berkas", "Dr_Richard_Burke.jpg" } , { "Frenkas Biufei jaunesnynis", "Frank_Buffay_Jr.jpg" }    , { "Leonardas Green", "Leonard_Green.jpg" } 
                    , { "Sandra Green", "Sandra_Green.jpg" }    , { "Edis Manoickas", "Eddie_Manoick.jpg" } , { "Markas Robinsonas", "Mark_Robinson.jpg" }  , { "Sofi", "Sophie.jpg" } 
                    , { "Fibi Abot", "Phoebe_Abbott.jpg" }  , { "Pitas Bekeris", "Pete_Becker.jpg" }    , { "Elis Nait Bufei", "Alice_Knight_Buffay.jpg" }  , { "Keiti", "Kathy.jpg" } 
                    , { "Emili Voltham", "Emily_Waltham.jpg" }  , { "Džošuo Burginas", "Joshua_Burgin.jpg" }    , { "Ponas Zelneris", "Mr_Zelner.jpg" } , { "Garis", "Gary.jpg" }  
                    , { "Elizabet Stevens", "Elizabeth_Stevens.jpg" }   , { "Jil Green", "Jill_Green.jpg" } , { "Tagas Jaunsas", "Tag_Jones.jpg" }  , { "Mona", "Mona.jpg" }  
                    , { "Daktarė Long", "Dr_Long.jpg" } , { "Eimi Green", "Amy_Green.jpg" } , { "Čarli Vyner", "Charlie_Wheeler.jpg" }  , { "Erika", "Erica.jpg" }
                    , { "Giunteris", "Gunther.jpg" }    , { "Jekas Geleris", "Jack_Geller.jpg" }    , { "Uršula Bufei", "Ursula_Buffay.jpg" }   , { "Marselis", "Marcel.jpg" }  
                    , { "Paulo", "Paolo.jpg" }  , { "Deividas", "David.jpg" }   , { "Džiuli", "Julie.jpg" } , { "Estelė Leonard", "Estelle_Leonard.jpg" }   
                    , { "Maikas Haniganas", "Mike_Hannigan.jpg" }   , { "Džanin Lacroiks", "Janine_LaCroix.jpg" }   , { "Dvokianti Katė", "Smelly_Cat.jpg" }    
                    , { "Unagi", "Unagi.jpg" }  , { "Raudonasis Rosas", "Red_Ross.jpg" }    , { "Jemenas", "Yemen.jpg" }    , { "Šarvuotis", "Armadillo.jpg" } 
                    , { "Kalėjime!", "In_Prison.jpg" }  , { "Va! Pach!", "Wah_Pah.jpg" }    , { "Centrinis Perkas", "Central_Perk.jpg" }

                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "D.R.A.U.G.A.I kaladė";
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
