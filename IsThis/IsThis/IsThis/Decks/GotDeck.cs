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
                string[,] allQuestions_in_orderEN = { { "Eddard Stark", "Eddard_Stark.jpg" }  , { "Jaime Lannister", "Jaime_Lannister.jpg" }  , { "Sansa Stark", "Sansa_Stark.jpg" }  
                    , { "Khal Drogo", "Khal_Drogo.jpg" }    , { "Bronn", "Bronn.jpg" }  , { "Shae", "Shae.jpg" }    , { "Gilly", "Gilly.jpg" }  , { "Missandei", "Missandei.jpg" } 
                    , { "Roose Bolton", "Roose_Bolton.jpg" }    , { "High Sparrow", "High_Sparrow.jpg" }    , { "Margaery Tyrell", "Margaery_Tyrell.jpg" }  , { "Dracarys", "Dracarys.jpg" }  
                    , { "Night's Watch", "Nights_Watch.jpg" }   , { "Cersei Lannister", "Cersei_Lannister.jpg" }    , { "Daenerys Targaryen", "Daenerys_Targaryen.jpg" } 
                    , { "Jon Snow", "Jon_Snow.jpg" }    , { "Rob Stark", "Rob_Stark.jpg" }  , { "Robert Baratheon", "Robert_Baratheon.jpg" }    , { "Tyrion Lannister", "Tyrion_Lannister.jpg" } 
                    , { "Catelyn Tully", "Catelyn_Tully.jpg" }  , { "Joffrey Baratheon", "Joffrey_Baratheon.jpg" }  , { "Arya Stark", "Arya_Stark.jpg" }  
                    , { "Theon Greyjoy", "Theon_Greyjoy.jpg" }  , { "Sandor Clegane", "Sandor_Clegane.jpg" }    , { "Brienne of Tarth", "Brienne_of_Tarth.jpg" }    
                    , { "Tommen Baratheon", "Tommen_Baratheon.jpg" }    , { "Brandon Stark", "Brandon_Stark.jpg" }  , { "Loras Tyrell", "Loras_Tyrell.jpg" }    
                    , { "Petyr Baelish", "Petyr_Baelish.jpg" }  , { "Varys", "Varys.jpg" }  , { "Samwell Tarly", "Samwell_Tarly.jpg" }  , { "Yara Greyjoy", "Yara_Greyjoy.jpg" } 
                    , { "Tormund", "Tormund.jpg" }  , { "Jorah Mormont", "Jorah_Mormont.jpg" }  , { "Onion Knight", "Onion_Knight.jpg" }    , { "Daario Naharis", "Daario_Naharis.jpg" }
                    , { "Melisandre", "Melisandre.jpg" }    , { "Ramsay Snow", "Ramsay_Snow.jpg" }  , { "House Stark", "House_Stark.jpg" }  , { "Direwolf", "Direwolf.jpg" }   
                    , { "House Tully", "House_Tully.jpg" }  , { "House Lannister", "House_Lannister.jpg" }  , { "House Tyrell", "House_Tyrell.jpg" }   
                    , { "House Targaryen", "House_Targaryen.jpg" }  , { "House Bolton", "House_Bolton.jpg" }    , { "House Frey", "House_Frey.jpg" }    , { "House Greyjoy", "House_Greyjoy.jpg" }
                    , { "House Martell", "House_Martell.jpg" }  , { "House Arryn", "House_Arryn.jpg" }  , { "House Karstark", "House_Karstark.jpg" }   
                    , { "House Baratheon", "House_Baratheon.jpg" }  , { "House Forrester", "House_Forrester.jpg" }  , { "House Baelish", "House_Baelish.jpg" } 
                    , { "House Mormont", "House_Mormont.jpg" }  , { "House Umber", "House_Umber.jpg" }  , { "House Reed", "House_Reed.jpg" }    , { "Free Folk", "Free_Folk.jpg" }  ,
                    { "White walkers", "White_walkers.jpg" }  , { "Giants", "Giants.jpg" }    , { "Children of the Forest", "Children_of_the_Forest.jpg" }    , { "Dothraki", "Dothraki.jpg" } 
                    , { "Qarth", "Qarth.jpg" }  , { "Slaver's Bay", "Slavers_Bay.jpg" } , { "Valyria", "Valyria.jpg" }  , { "Small Council", "Small_Council.jpg" }  , 
                    { "Golden cloaks", "Golden_cloaks.jpg" }  , { "Kingsguard", "Kingsguard.jpg" }    , { "Iron Bank of Braavos", "Iron_Bank_of_Braavos.jpg" }   
                    , { "Faceless Men", "Faceless_Men.jpg" }    , { "Unsullied", "Unsullied.jpg" }  , { "Brotherhood Without Banners", "Brotherhood_Without_Banners.jpg" }  , 
                    { "Many-Faced God", "ManyFaced_God.jpg" } , { "Old Gods of the Forest", "Old_Gods_of_the_Forest.jpg" }    , { "Faith of the Seven", "Faith_of_the_Seven.jpg" }  
                    , { "Drowned God", "Drowned_God.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Game of Thrones";
                Global.DeckInfo = "Game Of Thrones characters, quotes, cities, places.";
                Randomizing.Randomize(allQuestions_in_orderEN);
                
                //for (int i = 0; i < Global.QuestionQuantity; i++)
                //{
                //    Global.ShuffledQuestion[i, 0] = allQuestions_in_orderEN[Global.Numbers[i] , 0];
                //    Global.ShuffledQuestion[i, 1] = allQuestions_in_orderEN[Global.Numbers[i] , 1];
                //}

            }
            else
            {
                string[,] allQuestions_in_orderLT = {

                 { "Edardas Starkas", "Eddard_Stark.jpg" }  , { "Džeimis Lanisteris", "Jaime_Lannister.jpg" }   , { "Sansa Stark", "Sansa_Stark.jpg" }  , { "Khalas Drogas", "Khal_Drogo.jpg" } 
                    , { "Bronas", "Bronn.jpg" } , { "Šėja", "Shae.jpg" }    , { "Gilė", "Gilly.jpg" }   , { "Misandėja", "Missandei.jpg" }  , { "Ruzas Boltonas", "Roose_Bolton.jpg" } 
                    , { "Vyriausiasis žvirblis", "High_Sparrow.jpg" }   , { "Mardžeri Tairel", "Margaery_Tyrell.jpg" }  , { "Drakaris", "Dracarys.jpg" }  
                    , { "Nakties sargyba", "Nights_Watch.jpg" } , { "Sersėja Lanister", "Cersei_Lannister.jpg" }    , { "Deineris Targarian", "Daenerys_Targaryen.jpg" }  
                    , { "Džonas Snou", "Jon_Snow.jpg" } , { "Robas Starkas", "Rob_Stark.jpg" }  , { "Robertas Barateonas", "Robert_Baratheon.jpg" } , 
                 { "Tyrionas Lanisteris", "Tyrion_Lannister.jpg" } , { "Ketlina Tuli", "Catelyn_Tully.jpg" }   , { "Džofris Barateonas", "Joffrey_Baratheon.jpg" } 
                    , { "Arija Stark", "Arya_Stark.jpg" }   , { "Teonas Greidžojus", "Theon_Greyjoy.jpg" }  , { "Sandoras Klegeinas", "Sandor_Clegane.jpg" }    ,
                 { "Briana iš Tarto", "Brienne_of_Tarth.jpg" } , { "Tomenas Barateonas", "Tommen_Baratheon.jpg" }  , { "Brandonas Starkas", "Brandon_Stark.jpg" }  
                    , { "Loras Tairelis", "Loras_Tyrell.jpg" }  , { "Peteris Belišas", "Petyr_Baelish.jpg" }    , { "Varis", "Varys.jpg" }  , { "Semvelas Tarlis", "Samwell_Tarly.jpg" } 
                    , { "Jara Greidžoj", "Yara_Greyjoy.jpg" }   , { "Tormundas", "Tormund.jpg" }    , { "Džora Mormontas", "Jorah_Mormont.jpg" }    , { "Svogunų riteris", "Onion_Knight.jpg" } 
                    , { "Dario Naharis", "Daario_Naharis.jpg" } , { "Melisandra", "Melisandre.jpg" }    , { "Ramzis Snou", "Ramsay_Snow.jpg" }  , { "Starkų giminė", "House_Stark.jpg" }    ,
                 { "Didvilkis", "Direwolf.jpg" }   , { "Tulių giminė", "House_Tully.jpg" } , { "Lanisterių giminė", "House_Lannister.jpg" }    , { "Tairelių giminė", "House_Tyrell.jpg" } 
                    , { "Targarienų giminė", "House_Targaryen.jpg" }    , { "Boltonų giminė", "House_Bolton.jpg" }  , { "Frėjų giminė", "House_Frey.jpg" }  
                    , { "Greidžojų giminė", "House_Greyjoy.jpg" }   , { "Martelių giminė", "House_Martell.jpg" }    , { "Arino giminė", "House_Arryn.jpg" } , 
                 { "Karstarkų giminė", "House_Karstark.jpg" }  , { "Barateonų giminė", "House_Baratheon.jpg" } , { "Foresterių giminė", "House_Forrester.jpg" }    ,
                 { "Belišo giminė", "House_Baelish.jpg" }  , { "Mormontų giminė", "House_Mormont.jpg" }    , { "Amberių giminė", "House_Umber.jpg" }   , { "Rydų giminė", "House_Reed.jpg" } 
                    , { "Laisvoji tauta", "Free_Folk.jpg" } , { "Baltieji klajūnai", "White_walkers.jpg" }  , { "Milžinai", "Giants.jpg" }  , { "Miškavaikiai", "Children_of_the_Forest.jpg" }
                    , { "Dotrakiai", "Dothraki.jpg" }   , { "Kvartas", "Qarth.jpg" }    , { "Vergų įlanka", "Slavers_Bay.jpg" } , { "Senoji Valyrija", "Valyria.jpg" } 
                    , { "Mažoji taryba", "Small_Council.jpg" }  , { "MIesto sargyba", "Golden_cloaks.jpg" } , { "Karaliaus sargyba", "Kingsguard.jpg" } 
                    , { "Geležinis Bravoso bankas", "Iron_Bank_of_Braavos.jpg" }    , { "Beveidžiai žmonės", "Faceless_Men.jpg" }   , { "Nesuteptieji", "Unsullied.jpg" } 
                    , { "Brolija be vėliavų", "Brotherhood_Without_Banners.jpg" }   , { "Daugiaveidis dievas", "ManyFaced_God.jpg" }    , { "Senieji miško dievai", "Old_Gods_of_the_Forest.jpg" }
                    , { "Septynetas", "Faith_of_the_Seven.jpg" }    , { "Nuskrendęs dievas", "Drowned_God.jpg" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Sostų karai";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);
                
            }
        }
    }
}