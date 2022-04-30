using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class TouchLight : MonoBehaviour
{
    private Light2D light2D;

    public float timer;
    public float timerMax = 1f;

    private void Awake()
    {
        light2D = transform.Find("light").GetComponent<Light2D>();

        timer = 0f;
    }


    private void Update()
    {
        timer += Time.deltaTime;
        light2D.intensity = Mathf.Lerp(1, 0, timer / timerMax);
        if (timer > timerMax)
        {
            Destroy(gameObject);
        }
    }
}
