/* Menu_Button.cs
 * Uses input from a UI dropdown element to change to the selected scene when the button is pressed.
 * Rob Sheridan
 */

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Button : MonoBehaviour {

    public Dropdown sceneSelect;

	public void OnClick()
    {
        switch(sceneSelect.value)
        {
            //Use the Dropdown.Value index from the referenced dropdown object to determine actions when the button is pressed.
            case 1:
                SceneManager.LoadScene("QuaternionRotation");
                break;
            case 2:
                SceneManager.LoadScene("Color");
                break;
            case 3:
                SceneManager.LoadScene("UIDropdown");
                break;
        }
	}
}
