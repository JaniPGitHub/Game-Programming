using AD1701;
using UnityEngine;

namespace AD1701
{
    public class ItemPickup : MonoBehaviour
    {
        public string itemName = "Potion"; // Set this in the Inspector // Later get name from object?
        public int value = 1; // Set this in the Inspector

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) // Make sure the player has the "Player" tag
            {
                Inventory inventory = other.GetComponent<Inventory>();
                if (inventory != null)
                {
                    Item newItem = new Item(itemName, value);
                    inventory.AddItem(newItem);
                    Destroy(gameObject); // Remove item from the scene
                }
            }
        }
    } 
}
