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

        public Trie()
        {
            _root = new TrieNode(' ');
        }

        public void Build(string[] input)
        {
            foreach (string n in input)
            {
                this.addWord(n);
            }
        }

        public void addWord(string word)
        {
            TrieNode child = null;
            TrieNode current = _root;


        }

        public List<string> getList(string word)
        {

        }

        private List<string> getLists(TrieNode node, string prefix)
        {

        }

    }
}
