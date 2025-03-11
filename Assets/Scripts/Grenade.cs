using AD1701;
using Unity.FPS.Game;
using UnityEngine;

namespace AD1701
{
    public class Grenade : Weapon, IThrowable
    {
        public float damage = 40f;

        // TODO make your own areadamage!!!!!

        //public DamageArea = AreaOfDamage;
        //
        //public class DamageArea : MonoBehaviour
        //{
        //    public float AreaOfEffectDistance = 5f;
        //}
        //
        //void OnHit(Vector3 point, Vector3 normal, Collider collider)
        //{
        //    // damage
        //    if (AreaOfDamage)
        //    {
        //        // area damage
        //        AreaOfDamage.InflictDamageInArea(Damage, point, HittableLayers, k_TriggerInteraction,
        //            m_ProjectileBase.Owner);
        //    }
        //    else
        //    {
        //        // point damage
        //        Damageable damageable = collider.GetComponent<Damageable>();
        //        if (damageable)
        //        {
        //            damageable.InflictDamage(Damage, false, m_ProjectileBase.Owner);
        //        }
        //    } 
        //}
            public override void Attack()
        {
            throw new System.NotImplementedException();
        }

        public override void Equip()
        {
            throw new System.NotImplementedException();
        }

        public override void Unequip()
        {
            throw new System.NotImplementedException();
        }
    }
}