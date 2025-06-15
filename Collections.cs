﻿//e. Add a Value to an Existing Key: Append a new value to an existing key.
//f.Sort the Keys: Sort the keys in the dictionary.
using System;
namespace Collections
{ 
class Program
    {     static void Main(string[] args)
    {
SortedDictionary<int, string> characters = new SortedDictionary<int, string> ();

            characters.Add(89, "cipher");
            characters.Add(90, "encode");
            characters.Add(104, "decode");
            characters.Add(158, "encrypt");
            characters.Add(200, "decrypt");
            characters[200] = "garble"; // Update existing key

            //sort the keys values
            foreach (KeyValuePair<int, string> kvp in characters) 
        {
            Console.WriteLine($"Code: {kvp.Key}, Name: {kvp.Value}");
        }
    }
    }
}


