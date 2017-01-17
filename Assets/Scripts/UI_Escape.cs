using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UI_Escape : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.Escape))
            {
            SceneManager.LoadScene("MainMenu");
            }
    }
}
