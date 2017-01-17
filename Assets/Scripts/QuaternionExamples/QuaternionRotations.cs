/* QuaternionRotations.cs
 * Using Quaternion.Euler to rotate an object based on horizontal and vertical axis input.
 * Rob Sheridan
 */

using UnityEngine;

public class QuaternionRotations : MonoBehaviour
{
    public float maxDegrees = 90.0f;

    void Update()
    {
        //Apply a new rotation using vertical axis input for X and horizontal axis input for Z.
        //Input.GetAxis returns a value between 0 and 1 so we multiply this value by maxDegrees to achive the desired rotation.
        transform.rotation = Quaternion.Euler(Input.GetAxis("Vertical") * maxDegrees, 0, Input.GetAxis("Horizontal") * maxDegrees);
    }
}