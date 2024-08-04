using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonaDeProgramacaointerfatecs2024
{
    public class B_Teclado
    {
        public static void Main(string[] args)
        {
            string[] words;  
            int quant = 0;

            quant = int.Parse(Console.ReadLine());
            words = new string[quant];

            for (int i = 0; i < quant; i++)
            {
                words[i] = Console.ReadLine();   
            }

            GeneratePhoneCode(words);
        }

        public static void GeneratePhoneCode(string[] words)
        {
            char[] alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
            

            int len = words.Length;

            for(int i = 0; i<len; i++)
            {
                string phoneCode = "";
                int wordLen = words[i].Length;
                for(int j = 0; j<wordLen; j++)
                {
                    string word = words[i];
                    word = word.ToUpper();
                    char letter = word[j];
                    
                    if (letter == 'A' || letter == 'B' || letter == 'C')
                    {
                        phoneCode += '2';
                    }
                    else if(letter == 'D' || letter == 'E' || letter == 'F')
                    {
                        phoneCode += '3';
                    }
                    else if (letter == 'G' || letter == 'H' || letter == 'I')
                    {
                        phoneCode += '4';
                    }
                    else if (letter == 'J' || letter == 'K' || letter == 'L')
                    {
                        phoneCode += '5';
                    }
                    else if (letter == 'M' || letter == 'N' || letter == 'O')
                    {
                        phoneCode += '6';
                    }
                    else if (letter == 'P' || letter == 'Q' || letter == 'R' || letter == 'S')
                    {
                        phoneCode += '7';
                    }
                    else if (letter == 'T' || letter == 'U' || letter == 'V')
                    {
                        phoneCode += '8';
                    }
                    else if (letter == 'W' || letter == 'X' || letter == 'Y' || letter == 'Z')
                    {
                        phoneCode += '9';
                    }
                }
                Console.WriteLine(phoneCode);

            }


        }

    }
}
