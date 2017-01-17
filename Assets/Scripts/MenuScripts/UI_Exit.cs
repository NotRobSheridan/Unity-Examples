using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UI_Exit : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
