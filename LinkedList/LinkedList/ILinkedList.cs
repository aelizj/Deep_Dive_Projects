using System;

namespace Lists
{
    /// <summary>
    /// An interface describing basic properties and methods for a linked list.
    /// </summary>
    public interface ILinkedList
    {
        /// <summary>
        /// Gets the count of values in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the next element in the list.
        /// </summary>
        ILinkedList NextElement { get; }

        /// <summary>
        /// Gets the first value from the list.
        /// </summary>
        string FirstValue { get; }

        /// <summary>
        /// Gets the last value from the list.
        /// </summary>
        string LastValue { get; }

        /// <summary>
        /// Adds a value to the list.
        /// </summary>
        /// <param name="value">The value.</param>
        void Add(string value);

        /// <summary>
        /// Gets the value from the list at the given index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The value at the given index.</returns>
        /// <exception cref="IndexOutOfRangeException">This will be thrown if the index is out of range.</exception>
        string Get(int index);

        /// <summary>
        /// Removes a value from the list at the given index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The value that was removed.</returns>
        /// <exception cref="IndexOutOfRangeException">This will be thrown if the index is out of range.</exception>
        string Remove(int index);
    }
}
