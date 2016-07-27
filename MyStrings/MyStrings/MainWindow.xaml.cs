using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;
namespace MyStrings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int count = 0;
            foreach(char c in s)
            {
                count++;
            }
            return count;
        }
        bool contains(string s, string subs)
        {
            for(int i=0; i<length(s); i++)
            {
                if (s[i] == subs[0])
                {
                    for(int b=1; b<length(subs); b++)
                    {
                        i++;
                        if (s[i] == subs[b])
                        {
                            return true;
                        }
                    }
                    if (length(subs) == 1)
                    {
                        return true;
                    }
                }
            }
            return false;

           
        }
        int indexof(string s, string subs)
        {
            for (int i = 0; i < length(s); i++)
            {
                if (s[i] == subs[0])
                {
                    for (int b = 1; b < length(subs); b++)
                    {
                        i++;
                        if (s[i] == subs[b])
                        {
                            return b-1;
                        }
                    }
                    if (length(subs) == 1)
                    {
                        return i;
                    }
                }
            }
            return -1;

        }
        string insertsubstring(string s,string x,int pos)
        {
            if (pos > length(s)-1)
            {
                return s;
            }
            else
            {
                string news = "";
                int i = 0;
                while (i < pos)
                {
                    news = news + s[i];
                    i++;
                }
                if (i == pos)
                {
                    news = news + x;
                }

                i = i + 1;
                while (i < length(s))
                {
                    news = news + s[i];
                    i++;
                }

                return news;
            }
        }
        string replacesubstring(string s, string x, string sold)
        {
            int pos = indexof(s, sold);
            if (pos > length(s) - 1)
            {
                return s;
            }
            else
            {
                string news = "";
                int i = 0;
                while (i < pos)
                {
                    news = news + s[i];
                    i++;
                }
                if (i == pos)
                {
                    news = news + x;
                }

                i = i + length(sold);
                while (i < length(s))
                {
                    news = news + s[i];
                    i++;
                }

                return news;
            }
        }
        //List<string> split(string s, char c)
        //{
        //    int count = 0;
        //    foreach(char b in s)
        //    {
        //        if (b == c)
        //        {
        //            count++;
        //        }
        //    }
        //     while
        //}
        string caselow(char c)
        {
            switch (c)
            {
                case 'a':return "A";
                case 'b': return "B";
                case 'c': return "C";
                case 'd': return "D";
                case 'e': return "E";
                case 'f': return "F";
                case 'g': return "G";
                case 'h': return "H";
                case 'i': return "I";
                case 'j': return "J";
                case 'k': return "K";
                case 'l': return "L";
                case 'm': return "M";
                case 'n': return "N";
                case 'o': return "O";
                case 'p': return "P";
                case 'q': return "Q";
                case 'r': return "R";
                case 's': return "S";
                case 't': return "T";
                case 'u': return "U";
                case 'v': return "V";
                case 'w': return "W";
                case 'x': return "X";
                case 'y': return "Y";
                case 'z': return "Z";
                default:return ""+ c;


            }
        }
        string caseup(char c)
        {
            switch (c)
            {
                case 'A': return "a";
                case 'B': return "b";
                case 'C': return "c";
                case 'D': return "d";
                case 'E': return "e";
                case 'F': return "f";
                case 'G': return "g";
                case 'H': return "h";
                case 'I': return "i";
                case 'J': return "j";
                case 'K': return "k";
                case 'L': return "l";
                case 'M': return "m";
                case 'N': return "n";
                case 'O': return "o";
                case 'P': return "p";
                case 'Q': return "q";
                case 'R': return "r";
                case 'S': return "s";
                case 'T': return "t";
                case 'U': return "u";
                case 'V': return "v";
                case 'W': return "w";
                case 'X': return "x";
                case 'Y': return "y";
                case 'Z': return "z";
                default: return ""+c;

            }
        }
            string toUpper(string s)
        {
            string news = "";
            foreach(char c in s)
            {
                news=news+caselow(c);
            }
            return news;
        }
        string toLower(string s)
        {
            string news = "";
            foreach (char c in s)
            {
                news = news + caseup(c);
            }
            return news;
        }
        int stringcompare(string s1, string s2)
        {
            for (int i = 0; i < length(s1); i++)
            {
                if (s1[i] == s2[0])
                {
                    for (int b = 1; b < length(s2); b++)
                    {
                        i++;
                        if (s1[i] == s2[0])
                        {
                            return 0;
                        }

                    }
                    //if (length(s2) == 1)
                    //{
                    //    return true;
                    //}
                }
                else if (s1[i] < s2[0])
                {
                    return 1;
                }
                else if (s1[i] > s2[0])
                {
                    return -1;
                }
            }
            return 0;


        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("xxyxx"), 5);
            Tester.TestEq(length("the boy is"), 10);
            Tester.TestEq(length(" hellllllow"), 11);
            Tester.TestEq(length("h e l l o w"), 11);
            Tester.TestEq(length("bill,,,,lol"), 11);
            Tester.TestEq(length(""), 0);
            Tester.TestEq(length("  "), 2);





        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("xxyxx", "y"), true);
            Tester.TestEq(contains("xxyxx", "yx"), true);
            Tester.TestEq(contains("the boy is", "bil"), false);
            Tester.TestEq(contains("sorry to be mean", "be"), true);
            Tester.TestEq(contains("lol the", " "), true);
            Tester.TestEq(contains("tall or amall", " a"), true);
            Tester.TestEq(contains("the boy is", "l"), false);


        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(indexof("the boy is", "the"), 0);
            Tester.TestEq(indexof("the boy is", " "), 3);
            Tester.TestEq(indexof(",,,,,,.,,,", "."), 6);
            Tester.TestEq(indexof("", ""), -1);
            Tester.TestEq(indexof("the boy is", "o"), 5);
            Tester.TestEq(indexof("the boy is", "th"), 0);

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(insertsubstring("the boy is", "a fool", 7), "the boya foolis");
            Tester.TestEq(insertsubstring("hellow ", "world", 6), "hellowworld");
            Tester.TestEq(insertsubstring("the boy ", " kicks", 7), "the boy kicks");
            Tester.TestEq(insertsubstring(" ", "hellow world", 0), "hellow world");
            Tester.TestEq(insertsubstring("the boy is", "a fool", 10), "the boy is");
            Tester.TestEq(insertsubstring("mel", "ga", 2), "mega");
            Tester.TestEq(insertsubstring("singer", "ing with a sin", 4), "singing with a sinr");

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(replacesubstring("the boy is", "strong", "the"), "strong boy is");
            Tester.TestEq(replacesubstring("the boy is", "strong", "is"), "the boy strong");
            Tester.TestEq(replacesubstring("the boy is", "strong", "the"), "strong boy is");
            Tester.TestEq(replacesubstring("the boy is", "strong", "the"), "strong boy is");
            Tester.TestEq(replacesubstring("the boy is", "strong", "the"), "strong boy is");
            Tester.TestEq(replacesubstring("the boy is", "strong", "the"), "strong boy is");

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toUpper("low"), "LOW");
            Tester.TestEq(toUpper("holy"), "HOLY");
            Tester.TestEq(toUpper("123h"), "123H");
            Tester.TestEq(toUpper("h e l l 0"), "H E L L 0");
            Tester.TestEq(toUpper("mercy"), "MERCY");
            Tester.TestEq(toUpper("Great"), "GREAT");
            Tester.TestEq(toUpper("miss"), "MISS");
            Tester.TestEq(toUpper("CRY"), "CRY");

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toLower("LOW"), "low");
            Tester.TestEq(toLower("HOLY"), "holy");
            Tester.TestEq(toLower("123H"), "123h");
            Tester.TestEq(toLower("H E L L 0"), "h e l l 0");
            Tester.TestEq(toLower("MERCY"), "mercy");
            Tester.TestEq(toLower("gREAT"), "great");
            Tester.TestEq(toLower("MISS"), "miss");
            Tester.TestEq(toLower("CRY"), "cry");
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(stringcompare("hellow", "by"), -1);
            Tester.TestEq(stringcompare("hellow", "hellow"), 0);
            Tester.TestEq(stringcompare("by", "helloe"), 1);
            Tester.TestEq(stringcompare("hellow", "by"), -1);
            Tester.TestEq(stringcompare("hellow", "by"), -1);

        }
    }
}
