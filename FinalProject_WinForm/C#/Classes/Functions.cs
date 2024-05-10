using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject_WinForm
{
    public class Functions
    {
        public static bool CheckFormatEmail(string email)
        {
            for (int i = email.Length - 1; i >= 0; i--)
            {
                if (email[i] == '.')
                    for (int j = i - 1; j > 0; j--)
                        if (email[j] == '@')
                            return true;
            }
            return false;
        }
        public static string RemoveSpacing(string Name)
        {
            return Name.Replace(" ", "");
        }
        public static Image ByteArrayToImage(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    // Create the image directly from the byte array
                    Image image = Image.FromStream(new MemoryStream(byteArray));
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
                throw; // Re-throw the exception to propagate it to the caller
            }
        }

        public static User checkValidLogin(string userName, string userPassword, List<User> usersList)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                if (userName == usersList[i].Name && userPassword == usersList[i].Password)
                {
                    return usersList[i];
                }
            }
            return null;
        }
        
        public static bool checkValidYear(string year)
        {
            if (DateTime.Now.Year < Convert.ToInt32(year)) return false;
            return true;
        }

        public static bool checkValidQuantity(string q)
        {
            if(Convert.ToInt32(q) < 0) return false;
            return true;
        }
        // Compares the two strings based on letter pair matches
        public static double CompareStrings(string str1, string str2)
        {
            List<String> pairs1 = WordLetterPairs(str1.ToUpper());
            List<String> pairs2 = WordLetterPairs(str2.ToUpper());

            int intersection = 0;
            int union = pairs1.Count + pairs2.Count;

            for (int i = 0; i < pairs1.Count; i++)
            {
                for (int j = 0; j < pairs2.Count; j++)
                {
                    if (pairs1[i] == pairs2[j])
                    {
                        intersection++;
                        pairs2.RemoveAt(j);//Must remove the match to prevent "AAAA" from appearing to match "AA" with 100% success
                        break;
                    }
                }
            }

            return (2.0 * intersection * 100) / union; //returns in percentage
                                                       //return (2.0 * intersection) / union; //returns in score from 0 to 1
        }
        // Gets all letter pairs for each
        private static List<String> WordLetterPairs(string str)
        {
            List<String> AllPairs = new List<String>();

            // Tokenize the string and put the tokens/words into an array
            string[] Words = Regex.Split(str, @"\s");

            // For each word
            for (int w = 0; w < Words.Length; w++)
            {
                if (!string.IsNullOrEmpty(Words[w]))
                {
                    // Find the pairs of characters
                    String[] PairsInWord = LetterPairs(Words[w]);

                    for (int p = 0; p < PairsInWord.Length; p++)
                    {
                        AllPairs.Add(PairsInWord[p]);
                    }
                }
            }
            return AllPairs;
        }

        // Generates an array containing every two consecutive letters in the input string
        private static string[] LetterPairs(string str)
        {
            int numPairs = str.Length - 1;
            string[] pairs = new string[numPairs];

            for (int i = 0; i < numPairs; i++)
            {
                pairs[i] = str.Substring(i, 2);
            }
            return pairs;
        }
        public static OrderedItem convertItemToOrderItem(Items item)
        {
            OrderedItem tmp = new OrderedItem(item.ItemQuantity, item.ItemName, item.ItemId, item.UserName, item.ItemPrice);
            return tmp;
        }
    }
}
