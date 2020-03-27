using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneAusten
{
    public class Adjective : WordList<HashSet<string>>
    {
        private HashSet<Tuple<string,string>> List;
        private HashSet<string> AdjectiveList;
        private HashSet<string> AdverbList;
        private Random Random;
        public Adjective(HashSet<Tuple<string,string>> list)
        {
            Random = new Random();
            AdjectiveList = list.Where(x => !string.IsNullOrEmpty(x.Item1)).Select(x => x.Item1).ToHashSet();
            AdverbList = list.Where(x => !string.IsNullOrEmpty(x.Item2)).Select(x => x.Item2).ToHashSet();
            List = list;
        }

        public string RandomWord(bool capitalize = false)
        {
            string s = Random.Next(0,2) == 0 ? List.ElementAt(Random.Next(0, List.Count)).Item1 : List.ElementAt(Random.Next(0, List.Count)).Item2;
            return capitalize ? Capitalize(s) : s;
        }

        public string RandomAdjective(bool capitalize = false)
        {
            string s = AdjectiveList.ElementAt(Random.Next(0, AdjectiveList.Count));
            return capitalize ? Capitalize(s) : s;
        }

        public string RandomAdverb(bool capitalize = false)
        {
            string s = AdverbList.ElementAt(Random.Next(0, AdverbList.Count));
            return capitalize ? Capitalize(s) : s;
        }

        public string ParseWord(string word)
        {
            switch (word)
            {
                case "(adjective)":
                    return RandomAdjective();
                case "(adverb)":
                    return RandomAdverb();
                default:
                    return "ADJECTIVE ERROR";
            }

        }
    }
}
