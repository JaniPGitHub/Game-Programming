using AD1701;
using Unity.FPS.Game;
using UnityEngine;

namespace AD1701
{
    // Basic grenade that can be thrown and explodes
    public class Grenade : Weapon, IThrowable
    {
        [Header("Grenade Settings")]
        public float explosionRadius = 5f;
        public float explosionForce = 500f;
        public GameObject explosionEffect;
        public LayerMask damageableLayers;

        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public override void Attack()
        {
            Throw();
        }

        public void Throw()
        {
            // Launches grenade forward
            rb.AddForce(transform.forward * 10f, ForceMode.VelocityChange);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Explode();
        }

        // Handles explosion logic and effects
        protected virtual void Explode()
        {
            if (explosionEffect != null)
                Instantiate(explosionEffect, transform.position, Quaternion.identity);

            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, damageableLayers);

            foreach (Collider nearbyObject in colliders)
            {
                Damageable dmg = nearbyObject.GetComponent<Damageable>();
                if (dmg != null)
                {
                    dmg.InflictDamage(Damage, true, gameObject);
                }

                Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
                }
            }

            Destroy(gameObject);
        }

        public override void Equip()
        {
            gameObject.SetActive(true);
            rb.isKinematic = true;
            rb.useGravity = false;

            Collider col = GetComponent<Collider>();
            if (col != null)
                col.enabled = false;

            Debug.Log($"{weaponName} equipped.");
        }

        public override void Unequip()
        {
            rb.isKinematic = false;
            rb.useGravity = true;

            Collider col = GetComponent<Collider>();
            if (col != null)
                col.enabled = true;

            Debug.Log($"{weaponName} unequipped.");
        }
    }
}