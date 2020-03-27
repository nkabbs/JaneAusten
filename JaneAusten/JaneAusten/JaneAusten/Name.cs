using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneAusten
{
    public class Name
    {
        public List<Tuple<string, bool, int>> Names;
        private Random Random;
        public Name(List<Tuple<string, bool, int>> list)
        {
            Random = new Random();
            Names = list;
        }

        public Tuple<string, bool, int> RandomName()
        {
            int index = Random.Next(0, Names.Count);
            return Names.ElementAt(index);
        }

        public bool IsFemale(int characterNumber)
        {
            Tuple<string, bool, int> name = Names.Where(x => x.Item3 == characterNumber).FirstOrDefault();

            return name == null ? true : name.Item2;
        }

        public string ParseWord(string word)
        {
            int nameIndex = Convert.ToInt32(word.Substring(5,1));
            return Names.FirstOrDefault(x => x.Item3 == nameIndex).Item1;
        }
    }
}
