using System;
using System.Collections.Generic;
using UnityEngine;

namespace AD1701
{
    public class Inventory : MonoBehaviour
    {
        private List<Item> items = new List<Item>(); // stores items in inventory, holds all item objects

        public event Action<Item> OnItemAdded; // event, gets triggered when new item is added to inv.
                                               // passes Item as a parameter
        public void AddItem(Item newItem) // 
        {
            items.Add(newItem);
            OnItemAdded?.Invoke(newItem); // invokes event if there is subscriber for it
        }
    } 
}
