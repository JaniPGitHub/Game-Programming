using AD1701;
using UnityEngine;

namespace AD1701
{
    // Special grenade with electric effects
    public class ElectricGrenade : Grenade
    {
        [Header("Electric Grenade Settings")]
        public GameObject electricEffectPrefab;

        // Adds electric effect to base explosion
        protected override void Explode()
        {
            base.Explode();

            if (electricEffectPrefab != null)
            {
                Instantiate(electricEffectPrefab, transform.position, Quaternion.identity);
            }

            Debug.Log("Electric grenade exploded with electric VFX.");
        }
    }
}
