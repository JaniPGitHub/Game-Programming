using UnityEngine;

namespace AD1701
{
    public class ShootingTarget : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private Transform target;
        private int currentEndPointIndex = 0;
        public float speed = 1.0f;
      
        private void Start()
        {
            target = targetEndPoints[0];
        }

        // Update is called once per frame
        private void Update()
        {
            // Move our position a step closer to the target.
            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // Check if the position of the cube and sphere are approximately equal.
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                // Swap the position of the cylinder.
                SwapEndPointTarget();
            }
        }   
        public void SwapEndPointTarget()
        {
            currentEndPointIndex++;
            currentEndPointIndex %= targetEndPoints.Length;
            target = targetEndPoints[currentEndPointIndex];
        }
    } 
}
