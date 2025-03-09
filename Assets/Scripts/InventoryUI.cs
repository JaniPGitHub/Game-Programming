using AD1701;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace AD1701
{
    public class InventoryUI : MonoBehaviour
    {
        public Inventory inventory;
        public GameObject itemTextPrefab;
        public Transform itemListParent;

        //private void Awake()
        //{
        //    if (inventory == null)
        //    {
        //        inventory = FindFirstObjectByType<Inventory>(); // Finds Inventory in the scene
        //    }
        //}

        private void OnEnable()
        {
            if (inventory != null)
            {
                inventory.OnItemAdded += UpdateUI;
            }
        }

        private void OnDisable()
        {
            if (inventory != null)
            {
                inventory.OnItemAdded -= UpdateUI;
            }
        }

        private void UpdateUI(Item item)
        {
            GameObject newItemText = Instantiate(itemTextPrefab, itemListParent);
            newItemText.GetComponent<Text>().text = $"{item.ItemName} (Value: {item.Value})";
        }
    } 
}
