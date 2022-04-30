using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private static string BouncingScene = "Bouncing";

    public void Play()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(BouncingScene);
    }
}
