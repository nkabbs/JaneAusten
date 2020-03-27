using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneAusten
{
    public class Noun : WordList<HashSet<Tuple<string,string>>>
    {
        private HashSet<Tuple<string,string>> List;
        private HashSet<string> SingularList;
        private HashSet<string> PluralList;
        private Random Random;
        public Noun(HashSet<Tuple<string,string>> list)
        {
            Random = new Random();
            List = list;
            SingularList = list.Select(x => x.Item1).ToHashSet();
            PluralList = list.Where(x => !string.IsNullOrEmpty(x.Item2)).Select(x => x.Item2).ToHashSet();
        }

        public string RandomWord(bool capitalize = false)
        {
            Tuple<string,string> s = List.ElementAt(Random.Next(0, List.Count));
            string word = "";
            if (string.IsNullOrEmpty(s.Item2))
            {
                word = s.Item1;
            }
            else
            {
                word = Random.Next(0, 2) == 0 ? s.Item1 : s.Item2;
            }
            return capitalize ? Capitalize(word) : word;
        }

        
        public string ParseWord(string word)
        {
            switch(word)
            {
                case "(noun)":
                    return SingularList.ElementAt(Random.Next(0, SingularList.Count));
                case "(nounPlural)":
                    return PluralList.ElementAt(Random.Next(0, PluralList.Count));
                default:
                    return "NOUN ERROR";
            }
        }
    }
}
