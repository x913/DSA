﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DSA.DataStructures.Trees
{
    /// <summary>
    /// Represents a node in the <see cref="SuffixTreeMap{TValue}"/>.
    /// </summary>
    public class SuffixTreeMapNode<TValue>
    {
        /// <summary>
        /// Retrurns a dictionary containing the children of the <see cref="SuffixTreeMapNode{TValue}"/>.
        /// </summary>
        internal Dictionary<char, SuffixTreeMapNode<TValue>> children;

        /// <summary>
        /// Gets the char contained in the <see cref="SuffixTreeMapNode{TValue}"/>.
        /// </summary>
        public char Key { get; internal set; }

        /// <summary>
        /// Gets the Value contained in the <see cref="SuffixTreeMapNode{TValue}"/>. If the node is not terminal returns default value of the value type.
        /// </summary>
        public TValue Value { get; internal set; }

        /// <summary>
        /// Determines whether the <see cref="SuffixTreeMapNode{TValue}"/> is a terminal node.
        /// </summary>
        public bool IsTerminal { get; internal set; }

        /// <summary>
        /// Returns a read only dictionary containing the children of the <see cref="SuffixTreeMapNode{TValue}"/>.
        /// </summary>
        public ReadOnlyDictionary<char, SuffixTreeMapNode<TValue>> Children
        {
            get { return new ReadOnlyDictionary<char, SuffixTreeMapNode<TValue>>(children); }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SuffixTreeMapNode{TValue}"/> class, containing the specified char.
        /// </summary>
        /// <param name="key">The char to contain in the <see cref="SuffixTreeMapNode{TValue}"/>.</param>
        /// <param name="value">The value to contain in the <see cref="SuffixTreeMapNode{TValue}"/>. If node is not terminal the value of the node is the default value of its type.</param>
        /// <param name="isTerminal">Determines whether the node is terminal or not.</param>
        public SuffixTreeMapNode(char key, TValue value, bool isTerminal)
        {
            Key = key;
            IsTerminal = isTerminal;
            if (isTerminal) Value = value;
            else Value = default(TValue);
            children = new Dictionary<char, SuffixTreeMapNode<TValue>>();
        }
    }
}
