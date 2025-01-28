using UnityEngine;
using Unity.FPS.Game;

public class DamageableShootingTarget : Damageable
{
    public Renderer objectRenderer;
    public Color swapColor = Color.cyan;
    public Color originalColor;
    public bool colorSwapped = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    

    public override InflictDamage(float damage, bool isExplosionDamage, GameObject damageSource)
    {
        base.InflictDamage(damage, isExplosionDamage, damageSource);        
        SwapColor();
    }

    public void SwapColor()
    {
        if (!colorSwapped)
        { 
            objectRenderer.material.color = swapColor;
        }

    }

}
