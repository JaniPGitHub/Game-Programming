using UnityEngine;
using AD1701;

namespace AD1701
{
    public class Item
    {
        private string itemName; // Stores item name, private so can be modified only through class methods or properties
        private int value; // Stores item value or example cost of item

        public string ItemName => itemName; // => is for get only, read only
        public int Value => value; // other classes can access the item's value through this property

        public Item(string name, int val) // constructor, initializes itemName and value prop. when obj. created
        {
            itemName = name;
            value = val;
        }
    } 
}