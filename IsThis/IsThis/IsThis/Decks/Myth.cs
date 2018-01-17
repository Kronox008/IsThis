using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class Myth
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = {  { "Achilles", "Achilles.jpg" }  , { "Actaeon", "Actaeon.jpg" }  , { "Aegis", "Aegis.jpg" }  , { "Aetos Dios", "Aetos_Dios.jpg" }
                    , { "Aloadae", "Aloadae.jpg" }  , { "Amazons", "Amazons.jpg" }  , { "Ambrosia", "Ambrosia.jpg" }    , { "Amphion", "Amphion.jpg" } 
                    , { "Amphisbaena", "Amphisbaena.jpg" }  , { "Aphrodite", "Aphrodite.jpg" }  , { "Apollo", "Apollo.jpg" }    , { "Ares", "Ares.jpg" }  
                    , { "Argus Panoptes", "Argus_Panoptes.jpg" }    , { "Arion", "Arion.jpg" }  , { "Artemis", "Artemis.jpg" }  , { "Athena", "Athena.jpg" }  
                    , { "Atlanta", "Atlanta.jpg" }  , { "Calydonian Boar", "Calydonian_Boar.jpg" }  , { "Campe", "Campe.jpg" }  , { "Centaur", "Centaur.jpg" }  
                    , { "Cerberus", "Cerberus.jpg" }    , { "Ceryneian Hind", "Ceryneian_Hind.jpg" }    , { "Charybdis", "Charybdis.jpg" }  , { "Chimaera", "Chimaera.jpg" }  
                    , { "Chiron", "Chiron.jpg" }    , { "Chrysaor", "Chrysaor.jpg" }    , { "Cyclopes", "Cyclopes.jpg" }    , { "Cretan Bull", "Cretan_Bull.jpg" }
                    , { "Delphyne", "Delphyne.jpg" }    , { "Echidna", "Echidna.jpg" }  , { "Empusa", "Empusa.jpg" }    , { "Erymanthian Boar", "Erymanthian_Boar.jpg" } 
                    , { "Geryon", "Geryon.jpg" }    , { "Giants", "Giants.jpg" }    , { "Golden Fleece", "Golden_Fleece.jpg" }  , { "Gorgons", "Gorgons.jpg" }  
                    , { "Griffin", "Griffin.jpg" }  , { "Hades", "Hades.jpg" }  , { "Harpies", "Harpies.jpg" }  , { "Hecatoncheires", "Hecatoncheires.jpg" }   
                    , { "Hephaestus", "Hephaestus.jpg" }    , { "Hera", "Hera.jpg" }    , { "Heracles", "Heracles.jpg" }    , { "Hermes", "Hermes.jpg" }    , { "Hestia", "Hestia.jpg" }
                    , { "Ichor", "Ichor.jpg" }  , { "Jason", "Jason.jpg" }  , { "Ladon", "Ladon.jpg" }  , { "Laelaps", "Laelaps.jpg" }  , { "Lamia", "Lamia.jpg" }
                    , { "Lernaean Hydra", "Lernaean_Hydra.jpg" }    , { "Mares of Diomedes", "Mares_of_Diomedes.jpg" }  , { "Marsyas", "Marsyas.jpg" }  , { "Medusa", "Medusa.jpg" }  
                    , { "Minos", "Minos.jpg" }  , { "Minotaur", "Minotaur.jpg" }    , { "Mount Olympus", "Mount_Olympus.jpg" }  , { "Necklace of Harmonia", "Necklace_of_Harmonia.jpg" }
                    , { "Nectar", "Nectar.jpg" }    , { "Nemean Lion", "Nemean_Lion.jpg" }  , { "Nessus", "Nessus.jpg" }    , { "Odysseus", "Odysseus.jpg" }  
                    , { "Orthrus", "Orthrus.jpg" }  , { "Ouroboros", "Ouroboros.jpg" }  , { "Pegasus", "Pegasus.jpg" }  , { "Peleus", "Peleus.jpg" }    , { "Perseus", "Perseus.jpg" } 
                    , { "Phoenix", "Phoenix.jpg" }  , { "Polyphemus", "Polyphemus.jpg" }    , { "Poseidon", "Poseidon.jpg" }    , { "Scylla", "Scylla.jpg" }  
                    , { "Shield of Achilles", "Shield_of_Achilles.jpg" }    , { "Shirt of Nessus", "Shirt_of_Nessus.jpg" }  , { "Silenus", "Silenus.jpg" }  , { "Sirens", "Sirens.jpg" } 
                    , { "Sphinx", "Sphinx.jpg" }    , { "Stymphalian Birds", "Stymphalian_Birds.jpg" }  , { "Talos", "Talos.jpg" }  , { "Teumessian fox", "Teumessian_fox.jpg" },
                    { "The Underworld", "The_Underworld.jpg" }	, { "Theseus", "Theseus.jpg" }	, { "Typhon", "Typhon.jpg" }	, { "Troy", "Troy.jpg" }	, { "Zeus", "Zeus.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Mythology";
                Global.DeckInfo = "Mythology gods, characters, quotes, cities, places, items.";

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

                 { "Achilas", "https://drive.google.com/uc?id=1Ad9SoF06KWHxUwxdAbfgRf5ziNvUQmrp" }  
                    , { "Aegis", "https://drive.google.com/uc?id=12xM7kyfI0o-CgWyyle8Oz0lnDdNdvJko" }   , { "Chrisaoras", "https://drive.google.com/uc?id=1OlbejHFAKPZ-nok5abhpMcgtl0Bmi4M_" }  
                    , { "Erimanto šernas", "https://drive.google.com/uc?id=1QhECQUj8CC1gN-cElsi1Wrgvwj2NSryn" } , { "Gorgonės", "https://drive.google.com/uc?id=1Hvf8LunOJYEpTPbiKZ55-P4w1XGb_1gW" }
                    , { "Limfa", "https://drive.google.com/uc?id=1TrxFa4GY5BfUlzrX4nRKngBZJPnaY1WB" }   , { "Lelapas", "https://drive.google.com/uc?id=1X6dLrZ1JnAm6N2_6mznQ-2ugMW4IFYO7" } , { "Lernos hidra", "https://drive.google.com/uc?id=1d0PqAGOz6bLX1EcT_oE-518vdAsNm-cZ" }    , { "Diomedo žirgai", "https://drive.google.com/uc?id=1zh2X23aPoZ7vNrpzs8I-jj3RA0TlixSE" }  , { "Marsijas", "https://drive.google.com/uc?id=1IeKAGfh56W2hZoXEywfGqtKwYQ9QoI3M" }



                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Mitologija";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
