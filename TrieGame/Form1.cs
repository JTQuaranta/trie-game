using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrieGame
{
    public partial class Form1 : Form
    {
        Trie _trie;
        List<string> _result;

        public Form1()
        {
            InitializeComponent();
            _trie = new Trie();
            _result = new List<string>();
            _trie.Build(File.ReadAllLines("wordsEn.txt"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
