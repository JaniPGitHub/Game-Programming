using UnityEngine;

namespace AD1701
{
	public class Puppet : MonoBehaviour
	{
		public int puppetID;
		public string puppetName;
        private Vector3 rotationAxis = Vector3.right;
        private float rotationSpeed = 25.0f;

        private void Update()
        {
            transform.RotateAround(transform.position, rotationAxis, rotationSpeed * Time.deltaTime);
        }
    } 
}
