/* DropDownExamples.cs
 * Adds a list of strings to a dropdown box using Dropdown.AddOptions.
 * Uses UI Buttons to change the displayed list.
 * Rob Sheridan
 */

using UnityEngine;
using System.Collections.Generic;

using UnityEngine.UI;

public class ExpandedDropdownExample : MonoBehaviour
{
    //Declare lists of strings to display in the dropdown box.
    List<string> names = new List<string>() { "Oliver", "Noah", "Lily", "Amelia" };
    List<string> dates = new List<string>() { "January 1st", "March 25th", "April 1st", "June 30th", "December 24th", "February 18th" };
    List<string> places = new List<string>() { "London", "Paris", "Stockholm", "Berlin", "Shanghai", "Copenhagen", "Seoul", "Tokyo", "Montreal"};

    public Dropdown thisDropdown;

    void Start()
    {
        //Clear the dropdown box before adding options to it
        thisDropdown.ClearOptions();
    }

    //Functions to be accessed by the event system upon pressing the relevant OnClick() event.
    //Functions must be public so they can be accessed by the event system.
    public void OnNames()
    {
        thisDropdown.ClearOptions();
        thisDropdown.AddOptions(names);
    }
    public void OnPlaces() 
    {
        thisDropdown.ClearOptions();
        thisDropdown.AddOptions(places);
    }
    public void OnDates()
    {
        thisDropdown.ClearOptions();
        thisDropdown.AddOptions(dates);
    }

}
