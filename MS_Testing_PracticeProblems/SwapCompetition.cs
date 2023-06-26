using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_PracticeProblems
{
    public class SwapCompetition
    {
        public string SwapCondition(string one, string two)
        {
            List<string> list1 = new List<string>();
            list1.Sort();
            List<string> list2= new List<string>();
            list2.Sort();
            string word1=string.Join("",list1);
            string word2=string.Join("",list2);
            if(word1.Equals(word2))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
