using System;
using System.Collections.Generic;

namespace ABC {
    class Program {
        static string[] blocks = {
            "BO",
            "XK",
            "DQ",
            "CP",
            "NA",
            "GT",
            "RE",
            "TG",
            "QD",
            "FS",
            "JW",
            "HU",
            "VI",
            "AN",
            "OB",
            "ER",
            "FS",
            "LY",
            "PC",
            "ZM"
        };
        static void Main(string[] args) {
            Console.Write("Input Word: ");
            var answer = Console.ReadLine();

            if (can_make_word(answer)) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");    
            }
        }

        static bool can_make_word(string word) {
            int count = 0;
            List<int> usedBlocks = new List<int>();

            //loop through letters in word
            for (int j = 0; j < word.Length; j++) {
                
                //loop through blocks for each letter
                for (int i = 0; i < 20; i++) {
                    
                    //if the letter matches one of the letters on the block...
                    if (word[j].ToString().Equals(blocks[i][0].ToString().ToUpper()) 
                        || word[j].ToString().Equals(blocks[i][1].ToString().ToUpper()) 
                        || word[j].ToString().Equals(blocks[i][0].ToString().ToLower()) 
                        || word[j].ToString().Equals(blocks[i][1].ToString().ToLower())) {

                        //write where the letter was found, add 1 to the count
                        //add the block number to the used block list
                        //break out of the loop
                        if (usedBlocks.Contains(i + 1)) {
                            
                        }
                        else {
                            Console.WriteLine("Found " + word[j] + " at block number " + (i + 1));
                            count++;
                            usedBlocks.Add(i+1);
                            break;
                        }
                    }
                }
            }

            if (count == word.Length) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}