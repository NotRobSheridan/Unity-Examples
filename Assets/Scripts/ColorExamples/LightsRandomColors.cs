/* Menu_Randomcolors.cs
 * Uses Random.ColorHSV to change the colour of a spotlight to a random colour every second.
 * Rob Sheridan
 */
 
 using UnityEngine;
using System.Collections;

public class Menu_Randomcolors : MonoBehaviour {

    public Color newColor;
    public Light mainLight;
    public float randomSpeed = 1.0f;

	void Start ()
    {
        //Get a reference to the light component of the mainLight object
        mainLight = GetComponent<Light>();

        //InvokeRepeating is used to repeat the RandomColor function every second, rather than every frame.
        InvokeRepeating("RandomColor", 1.0f, randomSpeed);
    }

    void RandomColor()
    {
        //Apply the random colour to our light
        mainLight.color = Random.ColorHSV();
    }
}
