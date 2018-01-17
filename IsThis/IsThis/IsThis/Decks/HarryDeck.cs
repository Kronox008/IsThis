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
                string[,] allQuestions_in_orderEN = {  { "Alastor Moody", "Alastor_Moody.jpg" }   , { "Albus Dumbledore", "Albus_Dumbledore.jpg" }    , { "Alohomora", "Alohomora.jpg" } 
                    , { "Animagus", "Animagus.jpg" }    , { "Aragog", "Aragog.jpg" }    , { "Argus Filch", "Argus_Filch.jpg" }  , { "Basilisk", "Basilisk.jpg" }  
                    , { "Bellatrix Lestrange", "Bellatrix_Lestrange.jpg" }  , { "Boggart", "Boggart.jpg" }  , { "Cedric Diggory", "Cedric_Diggory.jpg" }    ,
                    { "Chamber of Secrets", "Chamber_of_Secrets.jpg" }    , { "Chinese Fireball", "Chinese_Fireball.jpg" }    , { "Chocolate Frog", "Chocolate_Frog.jpg" }    
                    , { "Common Welsh Green", "Common_Welsh_Green.jpg" }    , { "Cruciatus", "Cruciatus.jpg" }  , { "Cupboard Under the Stairs", "Cupboard_Under_the_Stairs.jpg" } 
                    , { "Death Eaters", "Death_Eaters.jpg" }    , { "Deathly Hallows", "Deathly_Hallows.jpg" }  , { "Dementor", "Dementor.jpg" }    , { "Diagon Alley", "Diagon_Alley.jpg" }  
                    , { "Dobby", "Dobby.jpg" }  , { "Dolores Umbridge", "Dolores_Umbridge.jpg" }    , { "Draco Malfoy", "Draco_Malfoy.jpg" }    , { "Elder Wand", "Elder_Wand.jpg" }  
                    , { "Every flavour beans", "Every_flavour_beans.jpg" }  , { "Floo Powder", "Floo_Powder.jpg" }  , { "Forbidden Forest", "Forbidden_Forest.jpg" }    
                    , { "Garrick Ollivander", "Garrick_Ollivander.jpg" }    , { "Gaunt's Ring", "Gaunts_Ring.jpg" } , { "Gilderoy Lockhart", "Gilderoy_Lockhart.jpg" }  , 
                    { "Gillyweed", "Gillyweed.jpg" }  , { "Ginny Weasley", "Ginny_Weasley.jpg" }  , { "Goblin", "Goblin.jpg" }    , { "Griffin", "Griffin.jpg" }  , { "Gryffindor", "Gryffindor.jpg" }
                    , { "Grim", "Grim.jpg" }    , { "Gringotts Wizarding Bank", "Gringotts_Wizarding_Bank.jpg" }    , { "Half-Blood Prince", "HalfBlood_Prince.jpg" }   
                    , { "Harry Potter", "Harry_Potter.jpg" }    , { "Hedwig", "Hedwig.jpg" }    , { "Hermione Granger", "Hermione_Granger.jpg" }    , { "Hogsmeade", "Hogsmeade.jpg" }  ,
                    { "Hogwarts", "Hogwarts.jpg" }    , { "Hogwarts Express", "Hogwarts_Express.jpg" }    , { "Horace Slughorn", "Horace_Slughorn.jpg" }  , { "Horcrux", "Horcrux.jpg" }  
                    , { "House cup", "House_cup.jpg" }  , { "House-elf", "Dobby.jpg" }  , { "Hufflepuff", "Hufflepuff.jpg" }    , { "Hufflepuff's Cup", "Hufflepuffs_Cup.jpg" } ,
                    { "Hungarian Horntail", "Hungarian_Horntail.jpg" }    , { "Imperio", "Imperio.jpg" }  , { "Invisibility cloak", "Invisibility_cloak.jpg" }    ,
                    { "Lucius Malfoy", "Lucius_Malfoy.jpg" }  , { "Lumos", "Lumos.jpg" }  , { "Luna Lovegood", "Luna_Lovegood.jpg" }  , { "Minerva McGonagall", "Minerva_McGonagall.jpg" }  
                    , { "Ministry of Magic", "Ministry_of_Magic.jpg" }  , { "Molly Weasley", "Molly_Weasley.jpg" }  , { "Mrs Norris", "Mrs_Norris.jpg" }    , { "Muggles", "Muggles.jpg" } 
                    , { "Nagini", "Nagini.jpg" }    , { "Neville Longbottom", "Neville_Longbottom.jpg" }    , { "Nimbus 2000", "Nimbus_2000.jpg" }  , { "Parselmouth", "Parselmouth.jpg" }
                    , { "Peron 9¾ ", "Peron__.jpg" }    , { "Peter Pettigrew", "Peter_Pettigrew.jpg" }  , { "Philosopher's Stone ", "Philosophers_Stone_.jpg" } , { "Pixie", "Pixie.jpg" } 
                    , { "Privet drive", "Privet_drive.jpg" }    , { "Protego", "Protego.jpg" }  , { "Ravenclaw", "Ravenclaw.jpg" }  , { "Ravenclaw's Diadem", "Ravenclaws_Diadem.jpg" } , 
                    { "Remus Lupin", "Remus_Lupin.jpg" }  , { "Resurrection Stone", "Resurrection_Stone.jpg" }    , { "Ron Weasley", "Ron_Weasley.jpg" }  , 
                    { "Room of Requirement", "Room_of_Requirement.jpg" }  , { "Rubeus Hagrid", "Rubeus_Hagrid.jpg" }  , { "Sectumsempra", "Sectumsempra.jpg" }    ,
                    { "Severus Snape", "Severus_Snape.jpg" }  , { "Sherbet Lemon", "Sherbet_Lemon.jpg" }  , { "Sirius Black", "Sirius_Black.jpg" }    , { "Slytherin", "Slytherin.jpg" } 
                    , { "Slytherin's Locket", "Slytherins_Locket.jpg" } , { "Sorting hat", "Sorting_hat.jpg" }  , { "Spell", "Spell.jpg" }  , { "Stupefy", "Stupefy.jpg" }  ,
                    { "Swedish Short-Snout", "Swedish_ShortSnout.jpg" }   , { "Testral", "Testral.jpg" }  , { "Tom Riddle", "Tom_Riddle.jpg" }    , { "Tom Riddle's diary", "Tom_Riddles_diary.jpg" } 
                    , { "Triwizard Tournament", "Triwizard_Tournament.jpg" }    , { "Troll", "Troll.jpg" }  , { "Vault 713", "Vault_713.jpg" }  , { "Vera verto", "Vera_verto.jpg" }   
                    , { "Voldemort", "Voldemort.jpg" }  , { "Wand", "Elder_Wand.jpg" }  , { "Whomping Willow", "Whomping_Willow.jpg" }  , { "Wingardium Leviosa", "Wingardium_Leviosa.jpg" }



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

                 { "Alastoras Rukna", "Alastor_Moody.jpg" }   , { "Albas Dumbldoras", "Albus_Dumbledore.jpg" }    , { "Alohomora", "Alohomora.jpg" }  , { "Animagas", "Animagus.jpg" } 
                    , { "Aragogas", "Aragog.jpg" }  , { "Argas Filčas", "Argus_Filch.jpg" } , { "Basiliskas", "Basilisk.jpg" }  , { "Belatriks Lestreindž", "Bellatrix_Lestrange.jpg" } 
                    , { "Kaukas", "Boggart.jpg" }   , { "Sedrikas Digoris", "Cedric_Diggory.jpg" }  , { "Paslapčių kambarys", "Chamber_of_Secrets.jpg" }    ,
                 { "Kinijos ugninis", "Chinese_Fireball.jpg" } , { "Šokoladinė varlė", "Chocolate_Frog.jpg" }  , { "Velso slibinas", "Common_Welsh_Green.jpg" }   
                    , { "Krusijo", "Cruciatus.jpg" }    , { "Sandėliukas po laiptais", "Cupboard_Under_the_Stairs.jpg" }    , { "Mirties valgytojas", "Death_Eaters.jpg" }  
                    , { "Mirties relikvijos", "Deathly_Hallows.jpg" }   , { "Psichas", "Dementor.jpg" } , { "Skersinis skersgatvis", "Diagon_Alley.jpg" }   , { "Dobis", "Dobby.jpg" }
                    , { "Dolores Umbridž", "Dolores_Umbridge.jpg" } , { "Drakas Smirdžius", "Draco_Malfoy.jpg" }    , { "Šeivamedžio lazdelė", "Elder_Wand.jpg" }   
                    , { "Visokių skonių pupelės", "Every_flavour_beans.jpg" }   , { "Kelionmilčiai", "Floo_Powder.jpg" }    , { "Uždraustasis miškas", "Forbidden_Forest.jpg" } ,
                 { "Olivanderis", "Garrick_Ollivander.jpg" }   , { "Gonto žiedas", "Gaunts_Ring.jpg" } , { "Gilderojus Lokhartas", "Gilderoy_Lockhart.jpg" }   , { "Žiaunažolės", "Gillyweed.jpg" }  
                    , { "Džinė Vizli", "Ginny_Weasley.jpg" }    , { "Goblinas", "Goblin.jpg" }  , { "Grifas", "Griffin.jpg" }   , { "Grifo gūžta", "Gryffindor.jpg" }   , { "Kraupas", "Grim.jpg" } ,
                 { "Gringoco bankas", "Gringotts_Wizarding_Bank.jpg" } , { "Netikras princas", "HalfBlood_Prince.jpg" }    , { "Haris Poteris", "Harry_Potter.jpg" }   , { "Hedviga", "Hedwig.jpg" } 
                    , { "Hermiona Įkyrelė", "Hermione_Granger.jpg" }    , { "Kiauliasodis", "Hogsmeade.jpg" }   , { "Hogvartsas", "Hogwarts.jpg" }  , { "Hogvartso ekspresas", "Hogwarts_Express.jpg" }
                    , { "Horacijus Trimitas", "Horace_Slughorn.jpg" }   , { "Horokrusas", "Horcrux.jpg" }   , { "Koledžo taurė", "House_cup.jpg" }  ,
                 { "Namų elfas", "Dobby.jpg" } , { "Švilpynė", "Hufflepuff.jpg" }  , { "Helgos Švilpynės taurė", "Hufflepuffs_Cup.jpg" }   , { "Vengrijos ragauodegis", "Hungarian_Horntail.jpg" } 
                    , { "Imperijo", "Imperio.jpg" } , { "Neregimumo apsiaustas", "Invisibility_cloak.jpg" } , { "Liucijus Smirdžius", "Lucius_Malfoy.jpg" } , { "Lumos", "Lumos.jpg" }  
                    , { "Luna Geranorė", "Luna_Lovegood.jpg" }  , { "Minerva Makonagal", "Minerva_McGonagall.jpg" } , { "Magijos ministerija", "Ministry_of_Magic.jpg" }  
                    , { "Molė Vizli", "Molly_Weasley.jpg" } , { "Ponia Noris", "Mrs_Norris.jpg" }   , { "Žiobaras", "Muggles.jpg" } , { "Nadžinė", "Nagini.jpg" }   
                    , { "Nevilis Nevėkšla", "Neville_Longbottom.jpg" }  , { "Aureolė 2000", "Nimbus_2000.jpg" } , { "Šnypštuolis", "Parselmouth.jpg" }  , { "9¾ peronas", "Peron__.jpg" }  
                    , { "Pyteris Trumpulis", "Peter_Pettigrew.jpg" }    , { "Išminties akmuo", "Philosophers_Stone_.jpg" }  , { "Kornvalio elfas", "Pixie.jpg" }  
                    , { "Liguistrų gatvė", "Privet_drive.jpg" } , { "Protego", "Protego.jpg" }  , { "Varno nagas", "Ravenclaw.jpg" }    , { "Varnanagės diadema", "Ravenclaws_Diadem.jpg" } ,
                 { "Remas Lupinas", "Remus_Lupin.jpg" }    , { "Prisikėlimo akmuo", "Resurrection_Stone.jpg" } , { "Ronas Vizlis", "Ron_Weasley.jpg" }
                    , { "Kambarys iki pareikalavimo", "Room_of_Requirement.jpg" }   , { "Rubijus Hagridas", "Rubeus_Hagrid.jpg" }   , { "Sanktum sempra", "Sectumsempra.jpg" }  
                    , { "Severas Sneipas", "Severus_Snape.jpg" }    , { "Citrinų šerbetas", "Sherbet_Lemon.jpg" }   , { "Sirijus Blekas", "Sirius_Black.jpg" }  , { "Klastunynas", "Slytherin.jpg" }  
                    , { "Salazaro Klastuolio medalionas", "Slytherins_Locket.jpg" } , { "Paskirstymo kepurė", "Sorting_hat.jpg" }   , { "Burtažodis", "Spell.jpg" } , { "Stupifai", "Stupefy.jpg" } ,
                 { "Švedijos trumpasnukis", "Swedish_ShortSnout.jpg" } , { "Testralis", "Testral.jpg" }    , { "Tomas Ridlis", "Tom_Riddle.jpg" }  ,
                 { "Tomo Ridlio dienoraštis", "Tom_Riddles_diary.jpg" }    , { "Burtų trikovės turnyras", "Triwizard_Tournament.jpg" } , { "Trolis", "Troll.jpg" } , { "713 saugykla", "Vault_713.jpg" }
                    , { "Vera verto", "Vera_verto.jpg" }    , { "Voldemortas", "Voldemort.jpg" }    , { "Burtų lazdelė", "Elder_Wand.jpg" } , { "Gluosnis galiūnas", "Whomping_Willow.jpg" } 
                    , { "Vingardium leviosa", "Wingardium_Leviosa.jpg" }


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

