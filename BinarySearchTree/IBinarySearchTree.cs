using System;
using System.Collections.Generic;

namespace Trees
{
    /// <summary>
    /// An interface describing basic properties and methods for a binary search tree.
    /// </summary>
    public interface IBinarySearchTree
    {
        /// <summary>
        /// Gets the count of elements in the tree.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets an enumeration of all keys in the tree in ascending order.
        /// </summary>
        IEnumerable<int> Keys { get; }

        /// <summary>
        /// Gets an enumeration of all values in the tree in ascending order by key.
        /// </summary>
        IEnumerable<string> Values { get; }

        /// <summary>
        /// Adds an element to the tree with the given key and value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <exception cref="InvalidOperationException">This will be thrown if an element with the given key already exists.</exception>
        void Add(int key, string value);

        /// <summary>
        /// Tries to add an element to the tree with the given key and value if an element with that key does not already exist.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>True if the element was added, false if an element with that key already exists.</returns>
        bool TryAdd(int key, string value);

        /// <summary>
        /// Gets the value of the element with the given key from the tree.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value.</returns>
        /// <exception cref="KeyNotFoundException">This will be thrown if an element with the given key does not exist.</exception>
        string Get(int key);

        /// <summary>
        /// Tries to get the value of the element from the tree with the given key if an element with the given key exists.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The output parameter that will contain the value if an element with the given key exists.</param>
        /// <returns>True if an element with the given key exists, false otherwise.</returns>
        bool TryGet(int key, out string value);

        /// <summary>
        /// Removes an element from the tree with the given key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value of the element that was removed.</returns>
        /// <exception cref="KeyNotFoundException">This will be thrown if an element with the given key does not exist.</exception>
        string Remove(int key);

        /// <summary>
        /// Tries to remove an element from the tree with the given key if an element with the given key exists.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The output parameter that will contain the value if an element with the given key is removed.</param>
        /// <returns>True if an element with the given key is removed, false otherwise.</returns>
        bool TryRemove(int key, out string value);
    }
}
