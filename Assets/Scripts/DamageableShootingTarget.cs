using Unity.FPS.Game;
using UnityEngine;

namespace AD1701
{
    public class DamageableShootingTarget : Damageable
    {
        public Renderer objectRenderer;
        public Color swapColor = Color.blue;
        public Color originalColor;
        public bool colorSwapped = false;

        private void Start()
        {
            objectRenderer = GetComponent<Renderer>();
            originalColor = objectRenderer.material.color;
        }

        public override void InflictDamage(float damage, bool isExplosionDamage, GameObject damageSource)
        {
            base.InflictDamage(damage, isExplosionDamage, damageSource);

            SwapColor();
        }

        public void SwapColor()
        {
            if (!colorSwapped)
            {
                // Set the swapColor to a random value when it is swapped
                swapColor = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));  // Prevent dark colors
                objectRenderer.material.color = swapColor;
            }
            else
            {
                objectRenderer.material.color = originalColor;
            }

            colorSwapped = !colorSwapped;
        }

        private void OnDisable()
        {
            objectRenderer.material.color = originalColor;
        }
    }
}
