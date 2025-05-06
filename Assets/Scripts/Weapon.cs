using UnityEngine;

namespace AD1701
{
    // Base abstract class for all weapons
    public abstract class Weapon : MonoBehaviour
    {
        public string weaponName;

        [SerializeField] private float damage = 1.0f;
        public float Damage => damage; // Read-only property

        public WeaponTypes weaponTypes;

        public abstract void Equip();   // Called when the weapon is equipped
        public abstract void Unequip(); // Called when the weapon is unequipped
        public abstract void Attack();  // Called when the weapon attacks
    }

    // Enum to classify weapons
    public enum WeaponTypes
    {
        Melee,
        Projectile,
        Explosive,
        Scifi
    }

    // Enum to classify damage types
    public enum DamageTypes
    {
        Electric,
        Fire,
        Ice,
        Earth,
        Air,
        Scifi,
        Darkness,
        Light
    }
}
