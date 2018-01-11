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
            string[ , ] allQuestions_in_order = { { "Gunther", "Gunther.png" }, { "Jack Geller", "jack_geller.jpg"}, {"Ursula Buffay", "Ursula_Buffay.jpg"},
            { "Marcel","marcel.jpg" }, {"Paolo", "Paolo.jpg"}, {"David", "David.jpg"}, {"Julie","Julie.jpg" }, {"Estelle Leonard","Estelle_Leonard.jpg" },
            {"Mike Hannigan","Mike_Hannigan.jpg" },  {"Janine LaCroix", "Janine_LaCroix.jpg" } };

            int count = (allQuestions_in_order.Length)/2;



            Global.Deckcounter = count;
            Global.DeckName = "F.R.I.E.N.D.S Deck";
            Global.DeckInfo = "deck info supposed to be here.......";
           Randomizing.Randomize();
           

            for (int i = 0; i < Global.QuestionQuantity; i++)
            {
                Global.ShuffledQuestion[i, 0] = allQuestions_in_order[Global.Numbers[i], 0];
                Global.ShuffledQuestion[i, 1] = allQuestions_in_order[Global.Numbers[i], 1];
            }
        }
       
    }
}
