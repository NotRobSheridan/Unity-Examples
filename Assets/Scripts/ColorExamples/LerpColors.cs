/* Lerpolours.cs
 * Uses Color.Lerp to lineraly interpolate between two colors.
 * Rob Sheridan
 */

using UnityEngine;
using UnityEngine.UI;

public class LerpColors : MonoBehaviour {

    public Text lerpText;
    public Color changeColor;
    public Color lerpColorA = Color.white;
    public Color lerpColorB = Color.black;

    void Update() {

        //Color.Lerp linearly interpolates between colors a and b by t.
        //When t is 0 Color.Lerp returns a, when t is 1 Color.Lerp returns b.
        changeColor = Color.Lerp(lerpColorA, lerpColorB, Mathf.PingPong(Time.time, 1));

        //Apply the lerped coluor.
        lerpText.color = changeColor;

    }

}
