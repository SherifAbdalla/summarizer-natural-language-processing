using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summerize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your paragraph");
            string inpout = Console.ReadLine().ToLower(); //"AUC Founded in 1919 and it wasn't a university at the beginning, AUC currently celebrating the 100 years arewe are in 2019, It's now one of the oldest universities in all around Egypt, AUC is a well known university in Egypt."; // 
            string[] e = new string[] { "the", "is", "are", "of", "in", "kg" };
            char[] s = new char[] { '.', ','};
            string[] Sentences;
            string[] Words;
            Dictionary<string, int> WordCount = new Dictionary<string, int>();
            Dictionary<string, int> SentenceWeight = new Dictionary<string, int>();
            Words = inpout.Split(new char[] { '.', ',' ,' ' });
            Sentences = inpout.Split(s);
            foreach (string word in Words)
            {
                //foreach (var item in e)
                //{
                    //if (word.Contains(item))
                      //  break;
                    //else
                    //{
                        WordCount[word] = 0;
                      //  break;
                    //}
                    
                //}
                
            }
            foreach (string word in Words)
            {
                //foreach (var item in e)
                //{
                  //  if (word.Contains(item))
                    //    break;
                   // else
                    //{
                        WordCount[word] = WordCount[word] + 1;
                      //  break;
                    //}
                //}
                
            }
            foreach (string Sentence in Sentences)
            {
                SentenceWeight[Sentence] = 0;
            }
            foreach (string Sentence in Sentences)
            {
                string[] WordsInSentences = Sentence.Split();
                foreach (var word in WordsInSentences)
                {
                    //foreach (var item in e)
                    //{
                      //  if (word.Contains(item))
                        //    break;
                        //else
                        //{
                            SentenceWeight[Sentence] = SentenceWeight[Sentence] + WordCount[word];
                          //  break;
                        //}
                    //}
                    

                }
            }
            List<KeyValuePair<string, int>> list = SentenceWeight.ToList();
            list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            List<KeyValuePair<string, int>> WordList = WordCount.ToList();
            WordList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            int p = Convert.ToInt32(list.Count * 0.5);
            var summ = list.Take(p).ToList();
            string Outpot = "";
            foreach (KeyValuePair<string, int> text in summ)
            {
                Outpot += text.Key;
            }
            Console.WriteLine(Outpot);
            Console.Read();
        }
    }
}
