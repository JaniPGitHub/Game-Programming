using UnityEngine;

public abstract class Potion
{
    public string Name { get; protected set; }

    public Potion(string name)
    {
        Name = name;
    }
    public abstract void GetHealth();
}
