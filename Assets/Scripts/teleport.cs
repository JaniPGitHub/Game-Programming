using UnityEngine;

namespace AD1701
{
    public class Teleport : MonoBehaviour
    {
        public Transform destination;

        void OnTriggerEnter(Collider other)
        {
            // Only teleport the object if it has the "Ball" tag
            if (other.CompareTag("Ball"))
            {
                other.transform.position = destination.position; // Teleport the Ball
            }
        }
    } 
}
