using UnityEngine;

public class HealthPotion : Potion
{
    public HealthPotion() : base("HealthPotion") { }

    public override void GetHealth()
    {
        Debug.Log($"{Name} Healing");
    }
}
