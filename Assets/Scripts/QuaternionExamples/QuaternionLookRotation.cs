/* QuaternionLookRotation.cs
 * Rotates one object towards another using Quaternion.Slerp for a smooth rotation.
 * Rob Sheridan
 */

using UnityEngine;

public class QuaternionLookRotation : MonoBehaviour {

    public Transform lookAt;
    public float speed = 1.0f;
	
	void Update ()
    {

        //Obtain relative position between this object and our target object
        Vector3 direction = transform.position - lookAt.position;

        //Use Quaternion.LookRotation to create a new rotation based on the forwards(Z axis) and upward (Y axis) position of our obejcts.
        Quaternion rotation = Quaternion.LookRotation(direction);

        //Apply the transformation using Quaternion.Slerp.Quaternion.Slerp spherically interpolates between a (transform.rotation), b (rotation) by t.
        //Larger values for t will make the object rotate faster
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

	}
}
