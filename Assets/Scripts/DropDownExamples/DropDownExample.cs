/* DropDownExamples.cs
 * Adds a list of strings to a dropdown box using Dropdown.AddOptions.
 * Rob Sheridan
 */

using UnityEngine;
using System.Collections.Generic;

using UnityEngine.UI;

public class DropDownExample : MonoBehaviour {

    public Dropdown thisDropdown;

    void Start()
    {
        //Declare a list of strings to display in the dropdown box.
        List<string> examples = new List<string>() { "These", "Are", "Example", "Options" };

        //Clear the dropdown box before adding options to it
        thisDropdown.ClearOptions();

        //Add the options from the examples list
        thisDropdown.AddOptions(examples);

    }

}
