namespace Trees
{ 
   public class BinarySearchTree : IBinarySearchTree
    {
       public int count { get; } 

       public IEnumerable<int> Keys { get; }

       public IEnumerable<string> Values { get; }


       public void Add(int key, string value)
       {

       }

       public bool TryAdd(int key, string value)
       {

       }

       public string Get(int key)
       {

       }

       public bool TryGet(int key, out string value)
       {

       }

       public string Remove(int key)
       {

       }

       public bool TryRemove(int key, out string value)
       {

       }
    }
}



/**______________________________________________________________
PROBLEM:

Build a binary search tree to implement the given interface.
_________________________________________________________________
UNDERSTANDING:

  RULES:
    - Left sub-tree of a node has a key less than or equal to
      the key of the parent node.
    - Right sub-tree of a node has a key greater than that of
      the parent node.
_________________________________________________________________
QUESTIONS:

  - Is the key user-specified when a node is added
    through the Add method?
    
  - Does the first node added become the "trunk" node?

        O <------ "trunk" node (this is what I'm calling it)
       / \
      O   O    |
     / \ / \   |-- Branch nodes
    O  OO   O  | 

  - If the trunk node is user-specified, and all
    subsequent node additions feature user-specified keys,
    how do we have any control over tree balance?
_________________________________________________________________
SUB-PROBLEMS - METHODS

  ADD-------  Inputs are an integer key and a string value.
              Method returns nothing.
   
  TRYADD----  Inputs are an integer key and a string value.
              Method returns true if element was successfully
              added, false otherwise.
   
  GET-------  Input is an integer key. Output is corresponding
              string value.
   
  TRYGET----  Input is an integer key. Output is true if element
              with given key exists, false otherwise.

  REMOVE----  Input is an integer key, output is the value of
              the removed string.

  TRYREMOVE-  Input is an integer key. Output is true if the
              corresponding element was removed, false otherwise.
______________________________________________________________**/
