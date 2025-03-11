using UnityEngine;

namespace AD1701
{
    public abstract class Weapon : MonoBehaviour
    {
        public string weaponName;
        [SerializeField] private float damage = 1.0f;

        public WeaponTypes weaponTypes;

        public abstract void Equip();

        public abstract void Unequip();

        public abstract void Attack();
    }

    public enum WeaponTypes
    {
        Melee,
        Projectile,
        Explosive,
        Scifi
    }
        
}
