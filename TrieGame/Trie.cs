using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieGame
{
    class Trie
    {
        private TrieNode _root;
       
        #region Constructors

        public Trie()
        {
            _root = new TrieNode(' ');
        }

        #endregion

        #region Methods (Tree Construction)

        public void Build(string[] input)
        {
            foreach (string n in input)
            {
                this.addWord(n);
            }
        }

        //run for each word in the .txt dict. fill the trie
        public void addWord(string word)
        {
            TrieNode child = null;
            TrieNode current = _root;

            char[] char_conversion = word.ToArray();

            foreach (char n in char_conversion)
            {
                if (current.getChild(n) == null)
                {
                    child = new TrieNode(n);
                    current.addSub(child);
                    current = child;
                }
                else
                {
                    current = current.getChild(n);
                }
            }

            //add an end character to the word's tree
            current.addSub(new TrieNode('\0'));
        }

        #endregion

        #region Methods (Tree Search)

        //initializes search for a word
        public List<string> getList(string word)
        {
            TrieNode current = _root;
            List<string> results = new List<string>();

            //"" case
            if (word == "")
            {
                results.Add("");
                return results;
            }

            //build the word. prefix and all
            for (int i = 0; i < word.Length; i++)
            {
                TrieNode temp = current;

                //loop through entire current node subtree
                foreach (TrieNode n in current.Subs)
                {
                    if (word[i] == n.Value)
                    {
                        current = n;
                        break;
                    }
                }

                //check if it's already in
                if (temp == current)
                {
                    results.Add(":y");
                    return results;
                }
            }

            //continue building tree using subtree words, search every possible prefix
            foreach (TrieNode n in current.Subs)
            {
                results.AddRange(this.getLists(n, word));
            }

            return results;
        }

        //used to search prefixes of original word
        private List<string> getLists(TrieNode node, string prefix)
        {
            List<string> results = new List<string>();

            //check if it's the end of a branch, add to list
            if (node.Value == '\0')
            {
                results.Add(prefix);
            }

            //if not, keep going
            else
            {
                prefix += node.Value;
                foreach (TrieNode n in node.Subs)
                {
                    results.AddRange(getLists(n, prefix));
                }
            }

            return results;
        }
        #endregion
    }
}
