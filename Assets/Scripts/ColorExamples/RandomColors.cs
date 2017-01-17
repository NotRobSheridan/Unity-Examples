/* RandomColours.cs
 * Uses Random.ColorHSV to randomly change the color of a text object.
 * Rob Sheridan
 */

using UnityEngine;
using UnityEngine.UI;

public class RandomColors : MonoBehaviour {

    public Text randomText;
    public Color randomColor;
    public float randomSpeed = 1.0f;

	void Start ()
    {
        //InvokeRepeating is used to repeat the RandomColor function every second, rather than every frame.
        InvokeRepeating("RandomColor", 1.0f, randomSpeed);
    }
	
    void RandomColor()
    {
        //Applies a random RGBa value to our text component.
        randomText.color = Random.ColorHSV();
    }
}
