using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThis.Decks
{
    class Animals
    {
        public static void SetDeckInfo()
        {
            if (Global.LanguageSelectedID == 0)
            {
                string[,] allQuestions_in_orderEN = { { "Fox", "Fox.jpg" }    , { "Seal", "Seal.jpg" }    , { "Welter", "Welter.jpg" } 
                    , { "Jellyfish", "Jellyfish.jpg" }  , { "Zebra", "Zebra.jpg" }  , { "Gorilla", "Gorilla.jpg" }  , { "Chimpanzee", "Chimpanzee.jpg" } 
                    , { "Armadillo", "Armadillo.jpg" }  , { "Whale", "Whale.jpg" }  , { "Cow", "Cow.jpg" }  , { "Horse", "Horse.jpg" }  , { "Goat", "Goat.jpg" }  
                    , { "Rooster", "Rooster.jpg" }  , { "Chicken", "Chicken.jpg" }  , { "Turkey", "Turkey.jpg" }    , { "Peacock", "Peacock.jpg" }  , { "Duck", "Duck.jpg" } 
                    , { "Swan", "Swan.jpg" }    , { "Goose", "Goose.jpg" }  , { "Bear", "Bear.jpg" }    , { "Polar bear", "Polar_bear.jpg" }    , { "Moose", "Moose.jpg" }  
                    , { "Raccoon dog", "Raccoon_dog.jpg" }  , { "Stork", "Stork.jpg" }  , { "Marten", "Marten.jpg" }    , { "Otter", "Otter.jpg" }  , { "Salmon", "Salmon.jpg" } 
                    , { "Lynx", "Lynx.jpg" }    , { "Beaver", "Beaver.jpg" }    , { "Lizard", "Lizard.jpg" }    , { "Pig", "Pig.jpg" }  , { "Boar", "Boar.jpg" }   
                    , { "Rabbit", "Rabbit.jpg" }    , { "Cormoran", "Cormoran.jpg" }    , { "Crane", "Crane.jpg" }  , { "Wolf", "Wolf.jpg" }   
                    , { "European bison", "European_bison.jpg" }    , { "Flatfish", "Flatfish.jpg" }    , { "Elephant", "Elephant.jpg" }    , { "Turtle", "Turtle.jpg" } 
                    , { "Puma", "Puma.jpg" }    , { "Deer", "Deer.jpg" }    , { "Panda", "Panda.jpg" }  , { "Camel", "Camel.jpg" }  , { "Rhino", "Rhino.jpg" } 
                    , { "Kangaroo", "Kangaroo.jpg" }    , { "Orangutan", "Orangutan.jpg" }  , { "Macaque", "Macaque.jpg" }  , { "Roe deer", "Roe_deer.jpg" }   
                    , { "Monitor lizard", "Monitor_lizard.jpg" }    , { "Koala", "Koala.jpg" }  , { "Dolphin", "Dolphin.jpg" }  , { "Hyena", "Hyena.jpg" } 
                    , { "Crocodile", "Crocodile.jpg" }  , { "Shark", "Shark.jpg" }  , { "Killer whale", "Killer_whale.jpg" }    , { "Piranha", "Piranha.jpg" }  
                    , { "Sheep", "Sheep.jpg" }  , { "Tiger", "Tiger.jpg" }  , { "Lion", "Lion.jpg" }    , { "Cheetah", "Cheetah.jpg" }  , { "Leopard", "Leopard.jpg" }
                    , { "Penguin", "Penguin.jpg" }  , { "Wild yak", "Wild_yak.jpg" }    , { "Octopus", "Octopus.jpg" }  , { "Lemurs", "Lemurs.jpg" }   
                    , { "Saiga", "Saiga.jpg" }  , { "Giraffe", "Giraffe.jpg" }  , { "Eagle", "Eagle.jpg" }  , { "Hawk", "Hawk.jpg" }    , { "Ostrich", "Ostrich.jpg" } 
                    , { "Platypus", "Platypus.jpg" }    , { "Kiwi", "Kiwi.jpg" }    , { "Grass-snake", "Grass-snake.jpg" }  , { "Bia", "Bia.jpg" }  , { "Cobra", "Cobra.jpg" }
                    , { "Cat", "Cat.jpg" }  , { "Dog", "Dog.jpg" }  , { "Guinea pig", "Guinea_pig.jpg" }    , { "Spider", "Spider.jpg" }    , { "Fly", "Fly.jpg" }  
                    , { "Bee", "Bee.jpg" }  , { "Worm", "Worm.jpg" }    , { "Eel", "Eel.jpg" }  , { "Northern pike", "Northern_pike.jpg" }  , { "Raccoon", "Raccoon.jpg" } 
                    , { "Wolverene", "Wolverene.jpg" }  , { "Pig", "Pig.jpg" }  , { "Squirrel", "Squirrel.jpg" }    , { "Woodpecker", "Woodpecker.jpg" }   
                    , { "Narwhal", "Narwhal.jpg" }  , { "Hippopotamus", "Hippopotamus.jpg" }    , { "Gazelle", "Gazelle.jpg" }  , { "Lama", "Lama.jpg" }  
                    , { "Crow", "Crow.jpg" }    , { "Ant-eater", "Ant-eater.jpg" }  , { "Mouse", "Mouse.jpg" }  , { "Rat", "Rat.jpg" }  , { "Fossa ", "Fossa_.jpg" }


                };

                int countEN = (allQuestions_in_orderEN.Length) / 2;



                Global.Deckcounter = countEN;
                Global.DeckName = "Animals";
                Global.DeckInfo = "Animals around the world";
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

                    { "Lapė", "Fox.jpg" }  , { "Ruonis", "Seal.jpg" }  , { "Vėplys", "Welter.jpg" }    , { "Medūza", "Jellyfish.jpg" } , { "Zebras", "Zebra.jpg" } 
                    , { "Gorila", "Gorilla.jpg" }   , { "Šimpanzė", "Chimpanzee.jpg" }  , { "Šarvuotis", "Armadillo.jpg" }  , { "Banginis", "Whale.jpg" }  
                    , { "Karvė", "Cow.jpg" }    , { "Arklys", "Horse.jpg" } , { "Ožka", "Goat.jpg" }    , { "Gaidys", "Rooster.jpg" }   , { "Višta", "Chicken.jpg" }  
                    , { "Kalakutas", "Turkey.jpg" } , { "Povas", "Peacock.jpg" }    , { "Antis", "Duck.jpg" }   , { "Gulbė", "Swan.jpg" }   , { "Žąsis", "Goose.jpg" } 
                    , { "Meška", "Bear.jpg" }   , { "Baltasis lokys", "Polar_bear.jpg" }    , { "Briedis", "Moose.jpg" }    , { "Usūrinis šuo", "Raccoon_dog.jpg" } 
                    , { "Gandras", "Stork.jpg" }    , { "Kiaunė", "Marten.jpg" }    , { "Ūdra", "Otter.jpg" }   , { "Lašiša", "Salmon.jpg" }   
                    , { "Lūšis", "Lynx.jpg" }   , { "Bebras", "Beaver.jpg" }    , { "Driežas", "Lizard.jpg" }   , { "Kiaulė", "Pig.jpg" }   , { "Šernas", "Boar.jpg" }
                    , { "Kiškis", "Rabbit.jpg" }    , { "Kormoranas", "Cormoran.jpg" }  , { "Gervė", "Crane.jpg" }  , { "Vilkas", "Wolf.jpg" } 
                    , { "Stumbras", "European_bison.jpg" }  , { "Plekšnė", "Flatfish.jpg" } , { "Dramblys", "Elephant.jpg" }    , { "Vėžlys", "Turtle.jpg" } 
                    , { "Puma", "Puma.jpg" }    , { "Elnias", "Deer.jpg" }  , { "Panda", "Panda.jpg" }  , { "Kupranugaris", "Camel.jpg" }   , { "Raganosis", "Rhino.jpg" }
                    , { "Kengūra", "Kangaroo.jpg" } , { "Orangutanas", "Orangutan.jpg" }    , { "Makaka", "Macaque.jpg" }   , { "Stirna", "Roe_deer.jpg" } 
                    , { "Varanas", "Monitor_lizard.jpg" }   , { "Koala", "Koala.jpg" }  , { "Delfinas", "Dolphin.jpg" } , { "Hiena", "Hyena.jpg" }
                    , { "Krokodilas", "Crocodile.jpg" } , { "Riklys", "Shark.jpg" } , { "Orka", "Killer_whale.jpg" }    , { "Piranija", "Piranha.jpg" } 
                    , { "Avis", "Sheep.jpg" }   , { "Tigras", "Tiger.jpg" } , { "Liūtas", "Lion.jpg" }  , { "Gepardas", "Cheetah.jpg" } , { "Leopardas", "Leopard.jpg" }  
                    , { "Pingvinas", "Penguin.jpg" }    , { "Jakas", "Wild_yak.jpg" }   , { "Aštuonkojis", "Octopus.jpg" }  , { "Lemūras", "Lemurs.jpg" }  
                    , { "Saiga", "Saiga.jpg" }  , { "Žirafa", "Giraffe.jpg" }   , { "Erelis", "Eagle.jpg" } , { "Vanagas", "Hawk.jpg" } , { "Strutis", "Ostrich.jpg" } 
                    , { "Ančiasnapis", "Platypus.jpg" } , { "Kivis", "Kiwi.jpg" }   , { "Žaltys", "Grass-snake.jpg" }   , { "Smauglys", "Bia.jpg" }
                    , { "Kobra", "Cobra.jpg" }  , { "Katinas", "Cat.jpg" }  , { "Šuo", "Dog.jpg" }  , { "Jūrų kiaulytė", "Guinea_pig.jpg" } 
                    , { "Voras", "Spider.jpg" } , { "Musė", "Fly.jpg" } , { "Bitė", "Bee.jpg" } , { "Sliekas", "Worm.jpg" } , { "Ungurys", "Eel.jpg" } 
                    , { "Lydeka", "Northern_pike.jpg" } , { "Meškėnas", "Raccoon.jpg" } , { "Ernis", "Wolverene.jpg" }  , { "Kiaulė", "Pig.jpg" }  
                    , { "Voverė", "Squirrel.jpg" }  , { "Genys", "Woodpecker.jpg" } , { "Narvalas", "Narwhal.jpg" } , { "Begemotas", "Hippopotamus.jpg" } 
                    , { "Gazelė", "Gazelle.jpg" }   , { "Lama", "Lama.jpg" }    , { "Varna", "Crow.jpg" }   , { "Skruzdėda", "Ant-eater.jpg" }  , { "Pelė", "Mouse.jpg" } 
                    , { "Žiurkė", "Rat.jpg" }   , { "Fosa", "Fossa_.jpg" }


                };

                int countLT = (allQuestions_in_orderLT.Length) / 2;



                Global.Deckcounter = countLT;
                Global.DeckName = "Gyvūnai";
                Global.DeckInfo = "Kaladės informacija";
                Randomizing.Randomize(allQuestions_in_orderLT);

            }
        }
    }
}
