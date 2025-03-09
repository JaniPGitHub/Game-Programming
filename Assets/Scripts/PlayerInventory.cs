using AD1701;
using UnityEngine;

namespace AD1701
{
    public class PlayerInventory : MonoBehaviour
    {
        private Inventory inventory; // reference Invetory component attached on same GameObject
                                     // allows PlayerInvetory class to interact with inventory system

        void Awake()
        {
            inventory = GetComponent<Inventory>();
        }

        void OnEnable()
        {
            if (inventory != null)
            {
                inventory.OnItemAdded += HandleItemAdded; // Subscribe to event
            }
        }

        void OnDisable()
        {
            if (inventory != null)
            {
                inventory.OnItemAdded -= HandleItemAdded; // Unsubscribe to prevent memory leaks
            }
        }

        private void HandleItemAdded(Item item) // Debug.Log shows what items added to inv.
        {
            Debug.Log($"Picked up: {item.ItemName} (Value: {item.Value})");
        }
    }
}
