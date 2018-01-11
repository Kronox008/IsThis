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
            string[,] allQuestions_in_order = { { "Eddard (Ned) Stark", "Ned_Stark.jpg" }, { "Jaime Lannister", "Jaime_Lannister.jpeg"}, {"Sansa Stark", "Sansa_Stark.jpg"},
            { "Khal Drogo","Khal_Drogo.jpg" }, {"Bronn", "Bronn.jpg"}, {"Shae", "Shae.jpg"},
            {"Gilly","Gilly.jpg" }, {"Missandei","Missandei.jpg" }, {"Roose Bolton","Roose_Bolton.jpg" }, {"The High Sparrow", "The_High_Sparrow.jpg" },{"	Margaery Tyrell","Margaery_Tyrell.jpg	"} };

            int count = (allQuestions_in_order.Length) / 2;



            Global.Deckcounter = count;
            Global.DeckName = "Sostų karai";
            Global.DeckInfo = "Game Of Thrones characters, questes, cities, places.";
            Randomizing.Randomize();
            //Name
            Global.ShuffledQuestion[0, 0] = allQuestions_in_order[Global.Num1, 0];
            Global.ShuffledQuestion[1, 0] = allQuestions_in_order[Global.Num2, 0];
            Global.ShuffledQuestion[2, 0] = allQuestions_in_order[Global.Num3, 0];
            Global.ShuffledQuestion[3, 0] = allQuestions_in_order[Global.Num4, 0];
            Global.ShuffledQuestion[4, 0] = allQuestions_in_order[Global.Num5, 0];
            Global.ShuffledQuestion[5, 0] = allQuestions_in_order[Global.Num6, 0];
            Global.ShuffledQuestion[6, 0] = allQuestions_in_order[Global.Num7, 0];
            Global.ShuffledQuestion[7, 0] = allQuestions_in_order[Global.Num8, 0];
            Global.ShuffledQuestion[8, 0] = allQuestions_in_order[Global.Num9, 0];
            Global.ShuffledQuestion[9, 0] = allQuestions_in_order[Global.Num10, 0];
            //Picture
            Global.ShuffledQuestion[0, 1] = allQuestions_in_order[Global.Num1, 1];
            Global.ShuffledQuestion[1, 1] = allQuestions_in_order[Global.Num2, 1];
            Global.ShuffledQuestion[2, 1] = allQuestions_in_order[Global.Num3, 1];
            Global.ShuffledQuestion[3, 1] = allQuestions_in_order[Global.Num4, 1];
            Global.ShuffledQuestion[4, 1] = allQuestions_in_order[Global.Num5, 1];
            Global.ShuffledQuestion[5, 1] = allQuestions_in_order[Global.Num6, 1];
            Global.ShuffledQuestion[6, 1] = allQuestions_in_order[Global.Num7, 1];
            Global.ShuffledQuestion[7, 1] = allQuestions_in_order[Global.Num8, 1];
            Global.ShuffledQuestion[8, 1] = allQuestions_in_order[Global.Num9, 1];
            Global.ShuffledQuestion[9, 1] = allQuestions_in_order[Global.Num10, 1];
        }
    }
}