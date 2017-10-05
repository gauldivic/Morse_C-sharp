using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

////International Morse code is composed of five elements:
//short mark, dot or 'dit' (·) — 'dot duration' is one unit long
//longer mark, dash or 'dah' (–) — three units long
//inter-element gap between the dots and dashes within a character — one dot duration or one unit long
//short gap (between letters) — three units long
//medium gap (between words) — seven units long[1]
namespace WindowsFormsApplication1
{
    class morseLib
    {
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        bool keyExists;
        int letterValue;
        string [,] valueArray = new string[54,2]
            { 
                {"\u2022-","dah-dit"},//A
                {"-\u2022\u2022\u2022","dah-di-di-dit"},//B
                {"-\u2022-\u2022","dah-di-dah-dit"},//C
                {"-\u2022\u2022","dah-di-dit"},//D
                {"\u2022","dit"},//E
                {"\u2022\u2022-\u2022","di-di-dah-dit"},//F
                {"--\u2022","dah-dah-dit"},//G
                {"\u2022\u2022\u2022\u2022","di-di-di-dit"},//H
                {"\u2022\u2022","di-dit"},//I
                {"\u2022---","di-dah-dah-dah"},//J
                {"-\u2022-","dah-di-dah"},//K
                {"\u2022-\u2022\u2022","dah-di-dah-dah"},//L
                {"--","dah-dah" },//M
                {"-\u2022","dah-dit"},//N
                {"---","dah-dah-dah"},//O
                {"\u2022--\u2022","di-dah-dah-dit" },//P
                {"--\u2022-","dah-dah-di-dah"},//Q
                {"\u2022-\u2022","di-dah-dit"},//R
                {"\u2022\u2022\u2022","di-di-dit"},//S
                {"-","dah"},//T
                {"\u2022\u2022-","di-di-dah"},//U
                {"\u2022\u2022\u2022-","di-di-di-dah"},//V
                {"\u2022--","di-dah-dah" },//W
                {"-\u2022\u2022-","dah-di-di-dah"},//X
                {"-\u2022--","dah-di-dah-dah"},//Y
                {"--\u2022\u2022","dah-dah-di-dit"},//Z
                {"-----","dah-dah-dah-dah-dah"},//0
                {"\u2022----","di-dah-dah-dah-dah"},//1
                {"\u2022\u2022---","di-di-dah-dah-dah"},//2
                {"\u2022\u2022\u2022--","di-di-di-dah-dah"},//3
                {"\u2022\u2022\u2022\u2022-","di-di-di-di-dah"},//4
                {"\u2022\u2022\u2022\u2022\u2022","di-di-di-di-dit"},//5
                {"-\u2022\u2022\u2022\u2022","dah-di-di-di-dit"},//6
                {"--\u2022\u2022\u2022","dah-dah-di-di-dit"},//7
                {"---\u2022\u2022","dah-dah-dah-di-dit"},//8
                {"----\u2022","dah-dah-dah-dah-dit"},//9
                {"\u2022-\u2022-\u2022-","di-dah-di-dah-di-dah"},//"."
                {"--\u2022\u2022--","dah-dah-di-di-dah-dah"},//","
                {"\u2022\u2022--\u2022\u2022","di-di-dah-dah-di-dit" },//"?"
                {"\u2022----\u2022","di-dah-dah-dah-dah-dit"},//"'"
                {"-\u2022-\u2022--","dah-di-dah-di-dah-dah"},//"!"
                {"-\u2022\u2022-\u2022","dah-di-di-dah-dit"},//"/"
                {"-\u2022--\u2022","dah-di-dah-dah-dit"},//"("
                {"-\u2022--\u2022-","dah-di-dah-dah-di-dah"},//")"
                {"\u2022-\u2022\u2022\u2022","di-dah-di-di-dit"},//"&"
                {"---\u2022\u2022\u2022","dah-dah-dah-di-di-dit"},//":"
                {"-\u2022-\u2022-\u2022","dah-di-dah-di-dah-dit"},//";"
                {"-\u2022\u2022\u2022-","dah-di-di-di-dah" },//"="
                {"\u2022-\u2022-\u2022","di-dah-di-dah-dit" },//"+"
                {"-\u2022\u2022\u2022\u2022-","dah-di-di-di-di-dah" },//"-"
                {"\u2022\u2022--\u2022-","di-di-dah-dah-di-dah" },//"_"
                {"\u2022-\u2022\u2022-\u2022","di-dah-di-di-dah-dit" },// "
                {"\u2022\u2022\u2022-\u2022\u2022-","di-di-di-dah-di-di-dah" },//"$"
                {"\u2022--\u2022-\u2022","di-dah-dah-di-dah-dit"}//"@"
            };
       
        //enum Bob { A=1, B,C,D,E,F,G,H,'!'};
        
        //outputBox.Text = "\u2022";
        Dictionary<string, int> letterDictionary = new Dictionary<string, int>
        {
               {"A", 0},
               {"B", 1},
               {"C", 2},
               {"D", 3},
               {"E", 4},
               {"F", 5},
               {"G", 6},
               {"H", 7},
               {"I", 8},
               {"J", 9},
               {"K", 10},
               {"L", 11},
               {"M", 12},
               {"N", 13},
               {"O", 14},
               {"P", 15},
               {"Q", 16},
               {"R", 17},
               {"S", 18},
               {"T", 19},
               {"U", 20},
               {"V", 21},
               {"W", 22},
               {"X", 23},
               {"Y", 24},
               {"Z", 25},
               {"0",26},
               {"1",27},
               {"2",28},
               {"3",29},
               {"4",30},
               {"5",31},
               {"6",32},
               {"7",33},
               {"8",34},
               {"9",35},
               {".",36},
               {",",37},
               {"?",38},
               {"'",39},
               {"!",40},
               {"/",41},
               {"(",42},
               {")",43},
               {"&",44},
               {":",45},
               {";",46},
               {"=",47},
               {"+",48},
               {"-",49},
               {"_",50},
               {"\"",51},
               {"$",52},
               {"@",53}
        };

        public string getSequence(int letter,int style)
        {

            return valueArray[letter, style];
        }

        public bool keyCheck(string character)
        {
            
            if (letterDictionary.ContainsKey(character))
            {
                keyExists =  true;
            }
            else if (!letterDictionary.ContainsKey(character))
            {
                keyExists = false;
            }
            return keyExists;
        }
        public int getKey(string value)
        {
           
            //if(letterDictionary.ContainsKey(value))
            //{
            //    //Console.WriteLine("d = " + value);
            letterValue = letterDictionary[value];
                 //Console.WriteLine("The value of i: " +  letterDictionary[value]);
            //}
            //else if (!letterDictionary.ContainsKey(value))
            //{
            //    d = -1;
            //        // Console.Write("The value of i: " + d);
            //}
            return letterValue;
        }
        public void test()
        {
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] array2Da = new int[, ] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 } };
            // What the above means:
            // =====================
            // | 1 | 2 | 3 |
            // -------------
            // | 4 | 5 | 6 |
            // -------------
            // | 7 | 8 | 9 |
            // -------------
            // |10 |11 |12 |


            //Console.WriteLine("Number Of Columns: " + array2Da.GetLength(1).ToString());
            //Console.WriteLine("Number Of Rows: " + array2Da.GetLength(0).ToString());
            int i = 0;
            int j = 0;
           // int k = 0;
            string d;
            string fd;
          //  Console.Write("j:");
            while (j < array2Da.GetLength(1))
            {
                Console.Write("  j:" + j + "");
                j++;
            }
            j = 0;
         Console.WriteLine("");
            while (i < array2Da.GetLength(0))
            {
                Console.Write("---------\n");
              
              
                while (j < array2Da.GetLength(1))
                {
                    d = String.Format("{0,5}", (array2Da[i, j]).ToString());
                    fd = String.Format("|{0,-9}", d);
                    Console.Write(fd);
                    
                    j++;
                }
                Console.WriteLine("|");
                j = 0;
                i++;
            }
            Console.Write("---------");
        }

  
        public void PrintLine()
        {
            string d = "\t"+String.Format("|{0,10}", 1);
            string fd = String.Format("{0,-2}|", d);
            Console.Write(fd);
        }

        ////International Morse code is composed of five elements:
        //short mark, dot or 'dit' (·) — 'dot duration' is one unit long
        //longer mark, dash or 'dah' (–) — three units long
        //inter-element gap between the dots and dashes within a character — one dot duration or one unit long
        //short gap (between letters) — three units long
        //medium gap (between words) — seven units long[1]
        //public void testParse(  

    }
}
