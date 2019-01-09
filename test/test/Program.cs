using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] temp = new int[alice.Count()];
            scores = scores.Distinct().ToArray();
            LinkedList<string> list = new LinkedList<string>(scores.Select(x => x.ToString()).ToArray());
            for (int i = 0; i < alice.Count(); i++)
            {
                int score = alice[i];
                if (scores.Contains(alice[i]))
                    temp[i] = Array.IndexOf(scores, alice[i])+1;
                else
                {
                    int j = 0;
                    while (j < scores.Count() && scores[j] > score)
                    {
                        j++;
                    }
                    if (j==0)
                        list.AddFirst(score.ToString());
                    else
                    {
                        LinkedListNode<string> node = list.Find(scores[j-1].ToString());
                        list.AddAfter(node, score.ToString());
                    }
                    temp[i] = j+1;
                }
                scores = list.Select(x => Int32.Parse(x)).ToArray();    
            }
            return temp;
        }

        static void Main(string[] args)
        {
            int[] scores = { 100, 90, 90, 80, 75, 60 };
            int[] alice = { 50, 65, 77, 90, 102 };
            int[] result = climbingLeaderboard(scores, alice);
        }
    }
}
