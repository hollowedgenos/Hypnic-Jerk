using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene("Scenes/" + "Level1");
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("Scenes/" + "Level2");
        }
    }
}
