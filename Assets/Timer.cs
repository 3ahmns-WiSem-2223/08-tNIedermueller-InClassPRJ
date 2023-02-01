using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float startTime;
    
    [SerializeField] GameObject timerText;
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;
    [SerializeField] GameObject highscore;
    

    string time;
    bool endBool = false;
    float currentTime;
    void Start()
    {
        currentTime = startTime;
    }

   
    void Update()
    {
        if (!endBool)
        {
            currentTime -= 1 * Time.deltaTime;
        }

        timerText.GetComponent<TextMeshProUGUI>().text = TimeFormat(currentTime);

        if (currentTime <= 0)
        {
            End();
        }


    }

    string TimeFormat(float currentTime)
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        time = string.Format("{00:00}:{1:00}", minutes, seconds);
        return (time);
    }

    void End()
    {
        endBool = true;
        currentTime = 0;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }
}
