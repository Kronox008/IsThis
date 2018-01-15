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

                  { "Achilas", "Achilles.jpg" }  , { "Aktaeonas", "Actaeon.jpg" }    , { "Aegis", "Aegis.jpg" }  , { "Etonas", "Aetos_Dios.jpg" }    , { "Aloadai", "Aloadae.jpg" }  
                    , { "Amazonės", "Amazons.jpg" } , { "Ambrosija", "Ambrosia.jpg" }   , { "Amfionas", "Amphion.jpg" } , { "Amfisbaena ", "Amphisbaena.jpg" }  , { "Afroditė", "Aphrodite.jpg" } 
                    , { "Apolonas", "Apollo.jpg" }  , { "Arėjas", "Ares.jpg" }  , { "Argas", "Argus_Panoptes.jpg" } , { "Arionas", "Arion.jpg" }    , { "Artemisas", "Artemis.jpg" }    
                    , { "Atėnė", "Athena.jpg" } , { "Atlanta", "Atlanta.jpg" }  , { "Kalidono šernas", "Calydonian_Boar.jpg" }  , { "Kampė", "Campe.jpg" }  , { "Kentauras", "Centaur.jpg" } 
                    , { "Cerberis", "Cerberus.jpg" }    , { "Kerinėjos stirna", "Ceryneian_Hind.jpg" }  , { "Charibdė", "Charybdis.jpg" }   , { "Chimera", "Chimaera.jpg" } 
                    , { "Chironas", "Chiron.jpg" }  , { "Chrisaoras", "Chrysaor.jpg" }  , { "Ciklopas", "Cyclopes.jpg" }    , { "Kretos bulius", "Cretan_Bull.jpg" }    , 
                  { "Pitonas", "Delphyne.jpg" } , { "Echidna", "Echidna.jpg" }  , { "Empusa", "Empusa.jpg" }    , { "Erimanto šernas", "Erymanthian_Boar.jpg" } , { "Gerionas", "Geryon.jpg" }
                    , { "Milžinai", "Giants.jpg" }  , { "Auksinė vilna", "Golden_Fleece.jpg" }  , { "Gorgonės", "Gorgons.jpg" } , { "Grifai", "Griffin.jpg" }   , { "Hadas", "Hades.jpg" } 
                    , { "Harpijos", "Harpies.jpg" } , { "Hekatonkheirai", "Hecatoncheires.jpg" }    , { "Hefaistas", "Hephaestus.jpg" } , { "Hera", "Hera.jpg" }    , { "Heraklis", "Heracles.jpg" } 
                    , { "Hermis", "Hermes.jpg" }    , { "Hestija", "Hestia.jpg" }   , { "Limfa", "Ichor.jpg" }  , { "Jasonas", "Jason.jpg" }    , { "Ladonas", "Ladon.jpg" }   
                    , { "Lelapas", "Laelaps.jpg" }  , { "Lamija", "Lamia.jpg" } , { "Lernos hidra", "Lernaean_Hydra.jpg" }  , { "Diomedo žirgai", "Mares_of_Diomedes.jpg" } , 
                  { "Marsijas", "Marsyas.jpg" } , { "Meduza", "Medusa.jpg" }    , { "Minas", "Minos.jpg" }  , { "Minotauras", "Minotaur.jpg" }  , { "Olimpo kalnas", "Mount_Olympus.jpg" }
                    , { "Harmonijos karoliai", "Necklace_of_Harmonia.jpg" } , { "Nektaras", "Nectar.jpg" }  , { "Nemėjos liūtas", "Nemean_Lion.jpg" }   , { "Nesas", "Nessus.jpg" } , 
                  { "Odisėjas", "Odysseus.jpg" }    , { "Ortras", "Orthrus.jpg" }   , { "Uroboras", "Ouroboros.jpg" }   , { "Pegasas", "Pegasus.jpg" }  , { "Pelėlas", "Peleus.jpg" } 
                    , { "Persėjas", "Perseus.jpg" } , { "Feniksas", "Phoenix.jpg" } , { "Polifemas", "Polyphemus.jpg" } , { "Poseidonas", "Poseidon.jpg" }  , { "Scilė", "Scylla.jpg" } 
                    , { "Achilo skydas", "Shield_of_Achilles.jpg" } , { "Neso marškiniai", "Shirt_of_Nessus.jpg" }  , { "Silenai", "Silenus.jpg" }  , { "Sirenos", "Sirens.jpg" }   ,
                  { "Sfinksas", "Sphinx.jpg" }  , { "Stimfalo paukščiai", "Stymphalian_Birds.jpg" } , { "Talas", "Talos.jpg" }  , { "Teumesijos lapė", "Teumessian_fox.jpg" }   ,
                  { "Požemių pasaulis", "The_Underworld.jpg" }  , { "Tesėjas", "Theseus.jpg" }  , { "Tifonas", "Typhon.jpg" }   , { "Troja", "Troy.jpg" }   , { "Dzeusas", "Zeus.jpg" }


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
