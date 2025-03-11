using UnityEngine;

namespace AD1701
{
    public class HealthPotion : Potion
    {
        public HealthPotion() : base("HealthPotion") { }

        public override void GetHealth()
        {
            Debug.Log($"{Name} Healing");
        }
    } 
}
