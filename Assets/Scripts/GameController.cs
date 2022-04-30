using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static string BouncingScene = "Bouncing";

    bool pause = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SwitchTime();

        if (Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(BouncingScene);
    }

    private void SwitchTime()
    {
        pause = !pause;
        if (pause)
            Time.timeScale = 0.1f;
        else
            Time.timeScale = 1.0f;
    }
}
