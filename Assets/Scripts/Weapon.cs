using UnityEngine;

namespace AD1701
{
    public abstract class Weapon
    {
        public string Name { get; protected set; }

        public Weapon(string name)
        {
            Name = name;
        }
        public abstract void GetWeapon();
    }
}
