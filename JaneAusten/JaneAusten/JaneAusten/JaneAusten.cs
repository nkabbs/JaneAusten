using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JaneAusten.EnumUtility;

namespace JaneAusten
{
    public class JaneAusten
    {
        private Adjective Adjectives;
        private Noun Nouns;
        private Pronoun Pronouns;
        private Verb Verbs;
        private Name Names;
        private Random RandomInspirations;
        private SentenceStructure SentenceStructures;
        

        public JaneAusten()
        {
            Adjectives = new Adjective(LearnAdjectives());
            Nouns = new Noun(LearnNouns());
            Names = new Name(GenerateNames());
            Verbs = new Verb(LearnVerbs());
            Pronouns = new Pronoun(LearnPronouns());
            SentenceStructures = GenerateSentenceStructures();

            RandomInspirations = new Random();
        }

        public string WriteANovel()
        {
            string novel = "<p>";
            novel += WriteATitle();
            novel += WriteASentence();
            novel += WriteAStructuredSentence();
            novel += WriteAStructuredSentence();
            novel += WriteAStructuredSentence();
            novel += WriteAStructuredSentence();
            novel += WriteAStructuredSentence();
            novel += WriteAStructuredSentence();
            novel += "</p><p>";
            novel += WriteARandomSentence();
            novel += WriteARandomSentence();
            novel += WriteARandomSentence();
            novel += WriteARandomSentence();
            novel += WriteARandomSentence();
            novel += "</p>";

            return novel;
        }

        public string WriteASentence()
        {
            return "The " + Adjectives.RandomWord() + " " + Nouns.RandomWord() + " " + Verbs.RandomWord() + " their " + Nouns.RandomWord() + ". ";
        }

        public string WriteAStructuredSentence()
        {
            return SentenceStructures.GenerateRandomSentence();
        }

        public string WriteARandomSentence()
        {
            string s = "";
            int sentenceLength = RandomInspirations.Next(4, 25);
            int randomInspiration;
            for (int i = 0; i < sentenceLength; i++)
            {
                randomInspiration = RandomInspirations.Next(1, Enum.GetNames(typeof(WordTypes)).Length + 1);
                if (randomInspiration == (int)EnumUtility.WordTypes.Adjective)
                {
                    s += Adjectives.RandomWord(i == 0);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Noun)
                {
                    s += Nouns.RandomWord(i == 0);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Verb)
                {
                    s += Verbs.RandomWord(i == 0);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Pronoun)
                {
                    s += Pronouns.RandomWord(i == 0);
                }
                if (i != sentenceLength - 1)
                {
                    if (RandomInspirations.Next(1, 10) == 1)
                    {
                        s += ",";
                    }
                    s += " ";
                }
                else
                {
                    s += ". ";
                }
            }
            return s;
        }

        public string WriteATitle()
        {
            int titleLength = RandomInspirations.Next(2, 5);
            string title = "";
            int randomInspiration;
            for (int i = 0; i < titleLength; i++)
            {
                randomInspiration = RandomInspirations.Next(1, Enum.GetNames(typeof(WordTypes)).Length);
                if (randomInspiration == (int)EnumUtility.WordTypes.Adjective)
                {
                    title += Adjectives.RandomWord(true);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Noun)
                {
                    title += Nouns.RandomWord(true);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Verb)
                {
                    title += Verbs.RandomWord(true);
                }
                else if (randomInspiration == (int)EnumUtility.WordTypes.Pronoun)
                {
                    title += Pronouns.RandomWord(true);
                }
                if (i != titleLength - 1)
                {
                    title += " ";
                }
            }
            return "<h3>" + title + "</h3>";
        }


        private HashSet<Tuple<string,string>> LearnAdjectives()
        {
            HashSet<Tuple<string, string>> adjectives = new HashSet<Tuple<string, string>>();
            adjectives.Add(new Tuple<string, string>("calm", "calmly"));
            adjectives.Add(new Tuple<string, string>("composed", "composedly"));
            adjectives.Add(new Tuple<string, string>("decisive", "decisively"));
            adjectives.Add(new Tuple<string, string>("elegant", "elegantly"));
            adjectives.Add(new Tuple<string, string>("exhausted", "exhaustedly"));
            adjectives.Add(new Tuple<string, string>("formidable", "formidably"));
            adjectives.Add(new Tuple<string, string>("gracious", "graciously"));
            adjectives.Add(new Tuple<string, string>("handsome", "handsomely"));
            adjectives.Add(new Tuple<string, string>("headstrong", "headstrongly"));
            adjectives.Add(new Tuple<string, string>("ill-humored", "ill-humoredly"));
            adjectives.Add(new Tuple<string, string>("impudent", "impudently"));
            adjectives.Add(new Tuple<string, string>("indisposed", "indisposedly"));
            adjectives.Add(new Tuple<string, string>("indolent", "indolently"));
            adjectives.Add(new Tuple<string, string>("inferior", "inferiorly"));
            adjectives.Add(new Tuple<string, string>("inflexible", "inflexiblely"));
            adjectives.Add(new Tuple<string, string>("insignificant", "insignificantly"));
            adjectives.Add(new Tuple<string, string>("insolent", "insolently"));
            adjectives.Add(new Tuple<string, string>("insufferable", "insufferably"));
            adjectives.Add(new Tuple<string, string>("intimate", "intimately"));
            adjectives.Add(new Tuple<string, string>("kind", "kindly"));
            adjectives.Add(new Tuple<string, string>("pale", "palely"));
            adjectives.Add(new Tuple<string, string>("particular", "particularly"));
            adjectives.Add(new Tuple<string, string>("polite", "politely"));
            adjectives.Add(new Tuple<string, string>("precise", "precisely"));
            adjectives.Add(new Tuple<string, string>("private", "privately"));
            adjectives.Add(new Tuple<string, string>("rational", "rationally"));
            adjectives.Add(new Tuple<string, string>("refreshing", "refreshingly"));
            adjectives.Add(new Tuple<string, string>("remarkable", "remarkably"));
            adjectives.Add(new Tuple<string, string>("ridiculous", "ridiculously"));
            adjectives.Add(new Tuple<string, string>("settled", ""));
            adjectives.Add(new Tuple<string, string>("sickly", ""));
            adjectives.Add(new Tuple<string, string>("splendid", "splendidly"));
            adjectives.Add(new Tuple<string, string>("studious", "studiously"));
            adjectives.Add(new Tuple<string, string>("tedious", "tediously"));
            adjectives.Add(new Tuple<string, string>("vain", "vainly"));
            adjectives.Add(new Tuple<string, string>("wise", "wisely"));


            return adjectives;
        }

        private HashSet<Tuple<string,string>> LearnNouns()
        {
            HashSet<Tuple<string, string>> nouns = new HashSet<Tuple<string, string>>(); nouns.Add(new Tuple<string, string>("attitude", "attitudes"));
            nouns.Add(new Tuple<string, string>("character", "characters"));
            nouns.Add(new Tuple<string, string>("countenance", ""));
            nouns.Add(new Tuple<string, string>("defect", "defects"));
            nouns.Add(new Tuple<string, string>("disposition", "dispositions"));
            nouns.Add(new Tuple<string, string>("education", "educations"));
            nouns.Add(new Tuple<string, string>("enumeration", "enumerations"));
            nouns.Add(new Tuple<string, string>("establishment", "establishments"));
            nouns.Add(new Tuple<string, string>("expectation", "expectations"));
            nouns.Add(new Tuple<string, string>("experience", "experiences"));
            nouns.Add(new Tuple<string, string>("family", "families"));
            nouns.Add(new Tuple<string, string>("feeling", "feelings"));
            nouns.Add(new Tuple<string, string>("folly", "follies"));
            nouns.Add(new Tuple<string, string>("fortune", "fortunes"));
            nouns.Add(new Tuple<string, string>("gentleman", "gentlemen"));
            nouns.Add(new Tuple<string, string>("honour", "honours"));
            nouns.Add(new Tuple<string, string>("house", "houses"));
            nouns.Add(new Tuple<string, string>("ladyship", ""));
            nouns.Add(new Tuple<string, string>("library", "libraries"));
            nouns.Add(new Tuple<string, string>("likeness", ""));
            nouns.Add(new Tuple<string, string>("man", "men"));
            nouns.Add(new Tuple<string, string>("moment", "moments"));
            nouns.Add(new Tuple<string, string>("neighborhood", "neighborhoods"));
            nouns.Add(new Tuple<string, string>("occasion", "occasions"));
            nouns.Add(new Tuple<string, string>("opinion", "opinions"));
            nouns.Add(new Tuple<string, string>("particular", "particulars"));
            nouns.Add(new Tuple<string, string>("possession", "possessions"));
            nouns.Add(new Tuple<string, string>("propensity", "propensities"));
            nouns.Add(new Tuple<string, string>("property", "properties"));
            nouns.Add(new Tuple<string, string>("prospect", "prospects"));
            nouns.Add(new Tuple<string, string>("relation", "relations"));
            nouns.Add(new Tuple<string, string>("salutation", "salutations"));
            nouns.Add(new Tuple<string, string>("speech", "speeches"));
            nouns.Add(new Tuple<string, string>("temper", "tempers"));
            nouns.Add(new Tuple<string, string>("thing", "things"));
            nouns.Add(new Tuple<string, string>("truth", "truths"));
            nouns.Add(new Tuple<string, string>("weather", ""));
            nouns.Add(new Tuple<string, string>("wife", "wives"));
            nouns.Add(new Tuple<string, string>("leisure", ""));
            nouns.Add(new Tuple<string, string>("vigor", "vigors"));

            return nouns;
        }

        private HashSet<Tuple<string, string>> LearnPronouns()
        {
            HashSet<Tuple<string, string>> pronouns = new HashSet<Tuple<string, string>>();
            pronouns.Add(new Tuple<string, string>("he", "him"));
            pronouns.Add(new Tuple<string, string>("she", "her"));
            pronouns.Add(new Tuple<string, string>("it", "it"));
            pronouns.Add(new Tuple<string, string>("they", "them"));
            pronouns.Add(new Tuple<string, string>("this", "these"));
            pronouns.Add(new Tuple<string, string>("that", "those"));

            return pronouns;
        }

        private HashSet<Tuple<string,string, string, string>> LearnVerbs()
        {
            HashSet<Tuple<string, string, string, string>> verbs = new HashSet<Tuple<string, string, string, string>>();
            verbs.Add(new Tuple<string, string, string, string>("aspire", "aspires", "aspired", "aspiring"));
            verbs.Add(new Tuple<string, string, string, string>("bequeth", "bequeths", "bequethed", "bequething"));
            verbs.Add(new Tuple<string, string, string, string>("circumscribe", "circumscribes","circumscribed", "circumscribing"));
            verbs.Add(new Tuple<string, string, string, string>("acknowledge", "acknowledges", "acknowledged", "acknowleding"));
            verbs.Add(new Tuple<string, string, string, string>("flatter", "flatters", "flattered", "flattering"));
            verbs.Add(new Tuple<string, string, string, string>("marry", "marries", "married", "marrying"));
            verbs.Add(new Tuple<string, string, string, string>("hurry", "hurries", "hurried", "hurrying"));
            verbs.Add(new Tuple<string, string, string, string>("dawdle", "dawdles", "dawdled", "dawdling"));
            verbs.Add(new Tuple<string, string, string, string>("admire", "admires", "admired", "admiring"));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            //verbs.Add(new Tuple<string, string, string, string>("", "", "", ""));
            return verbs; 
        }

        private SentenceStructure GenerateSentenceStructures()
        {
            HashSet<List<string>> sentenceStructures = new HashSet<List<string>>();
            sentenceStructures.Add(new List<string>() { "(name1)", "(verbPast)", "the", "(nounPlural)", "with ", "(adjective)", "(noun)", ",", "(verbActive)", "at the", "(adjective)", "(noun)", "." });
            sentenceStructures.Add(new List<string>() { "if", "(name1)", ", when", "(name2)", "(verbPast)", "(her/him)1", "the", "(noun)", ",", "did not", "(verbSimple)", "it to", "(verbSimple)", "a", "(noun)", "of", "(her/his)2", ",", "(he/she)1", "had", "(verbPast)", "no", "(noun)", "at all of its ", "(nounPlural)", "." });
            sentenceStructures.Add(new List<string>() { "(name2)", "with", "(adjective)", "(noun)", "(verbPast)", "to be", "(verbPast)", "the", "(noun)", "of", "(her/his)1", "(noun)", "; but in", "(noun)", "." });
            sentenceStructures.Add(new List<string>() { "(name1)", "was", "(adjective)", "; nor did", "(name3)", "at all", "(verbSimple)", "(her/his)1", "(noun)", "by", "(her/his)3", "(noun)", "at", "(noun)", "." });
            sentenceStructures.Add(new List<string>() { "(name1)", "could", "(adverb)", "(verbSimple)", "that it was a", "(adjective)", "(noun)", "where that was the", "(noun)", ", and with", "(adjective)", "(noun)", "could", "(verbSimple)", "that", "(she/he)1", "(adverb)", "(verbPast)", "that was the", "(noun)", ".", "", "", "", "", "", "", "", "", "", "" });
            sentenceStructures.Add(new List<string>() { "(she/he)1", "was not", "(adjective)", ", however, to have the", "(noun)", "of them", "(verbPast)", "by the", "(noun)", "of the", "(noun)", "from whom they", "(verbPast)", "." });
            sentenceStructures.Add(new List<string>() { "At", "(noun)", "the", "(noun)", "(verbPast)", ", the", "(nounPlural)", "were", "(verbPast)", "on, the", "(nounPlural)", "(verbPast)", "within, and it was", "(verbPast)", "to be", "(adjective)", "." });

            SentenceStructure sentenceStructure = new SentenceStructure(sentenceStructures, Nouns, Verbs, Names, Pronouns, Adjectives);
            return sentenceStructure;
        }

        private List<Tuple<string, bool, int>> GenerateNames()
        {
            List<Tuple<string, bool, int>> names = new List<Tuple<string, bool, int>>();
            names.Add(new Tuple<string, bool, int>("Elizabeth", true, 1));
            names.Add(new Tuple<string, bool, int>("Darcy", false, 2));
            names.Add(new Tuple<string, bool, int>("Jane", true, 3));
            names.Add(new Tuple<string, bool, int>("Bingley", false, 4));

            return names;
        }
    }
}
