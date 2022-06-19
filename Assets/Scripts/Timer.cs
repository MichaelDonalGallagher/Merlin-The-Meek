using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startTime = 45f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startTime;
    }

    // Countdown Timer & Game Over
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();

        if(currentTime <= 0)
        {
            currentTime = 0;

            SceneManager.LoadScene("GameOver");
        }
    }
}
