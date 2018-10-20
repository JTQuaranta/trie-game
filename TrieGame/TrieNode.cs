﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieGame
{
    class TrieNode
    {
        private char _value;
        private List<TrieNode> _subs;

        #region Constructors

        public TrieNode(char c)
        {
            _value = c;
            _subs = new List<TrieNode>();
        }

        #endregion

        #region Methods

        public void addSub(TrieNode sub)
        {
            this._subs.Add(sub);
        }

        public TrieNode getChild(char c)
        {
            foreach (TrieNode n in this._subs)
            {
                if (n.Value == c)
                {
                    return n;
                }
            }
            return null;
        }

        #endregion

        #region Properties

        public char Value
        {
            get { return _value; }
            private set { _value = value; }
        }

        public List<TrieNode> Subs
        {
            get { return _subs; }
        }

        #endregion
    }
}
