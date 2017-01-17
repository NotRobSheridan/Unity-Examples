/* StayOnMose.cs
 * Fixes a the position of a Game Object to the position of the mouse pointer.
 * Rob Sheridan
 */
  
using UnityEngine;
using System.Collections;

public class StayOnMouse : MonoBehaviour {

    public static int zAxisPos = 0;
    public float speed = 10f;

    void Update()
    {
        //Create new Vector3 based on the position of the mouse pointer, fixing the Z position to our main camera's Z position.
        Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zAxisPos - Camera.main.transform.position.z);

        //Transforms the screen space position of our mouse pointer into world space.
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        //Apply the transformation to our object.
        this.transform.position = new Vector3(mouse.x, mouse.y, mouse.z);
    }
}