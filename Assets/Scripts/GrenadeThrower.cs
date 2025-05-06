using AD1701;
using UnityEngine;

namespace AD1701
{
    public class GrenadeThrower : MonoBehaviour
    {
        public GameObject grenadePrefab;
        public GameObject electricGrenadePrefab;

        public Transform DefaultWeaponPosition; // Using from player FirstPersonSocket in WeaponCamera

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                ThrowGrenade(grenadePrefab);
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                ThrowGrenade(electricGrenadePrefab);
            }
        }

        void ThrowGrenade(GameObject grenadePrefab)
        {
            if (grenadePrefab == null || DefaultWeaponPosition == null) return;

            // Instantiate grenade and simulate equip/unequip + attack
            GameObject grenade = Instantiate(grenadePrefab, DefaultWeaponPosition.position, DefaultWeaponPosition.rotation);

            Weapon weapon = grenade.GetComponent<Weapon>();
            if (weapon != null)
            {
                weapon.Equip();
                weapon.Unequip();
                weapon.Attack();
            }
        }
    } 
}
