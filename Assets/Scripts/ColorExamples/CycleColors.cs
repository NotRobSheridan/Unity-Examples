/* Cyclecolors.cs
 * Uses predefined static variables for Color to switch between colors each mouse click.
 * Rob Sheridan
 */

using UnityEngine;
using UnityEngine.UI;

public class CycleColors : MonoBehaviour {

    public Text theText;
    public int clicks = 0;
	
	void Update () {

        //Adds 1 to the clicks variable each time the left mouse button is pressed if clicks is less than 5.
        //If clicks is greater than 4, clicks is reset to 1.
        if (Input.GetMouseButtonDown(0))
        {
            if (clicks <= 4)
                clicks++;
            else
                clicks = 1;

            switch (clicks)
            {
                //Uses the clicks variable to switch between predefined static variables for Color.
                case 1:
                    theText.color = Color.red;
                    break;
                case 2:
                    theText.color = Color.blue;
                    break;
                case 3:
                    theText.color = Color.green;
                    break;
                case 4:
                    theText.color = Color.yellow;
                    break;
                case 5:
                    theText.color = Color.cyan;
                    break;
                default:
                    theText.color = Color.white;
                    break;
            }
        }
    }
}
