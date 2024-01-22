using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer_Script_Lose_Screen : MonoBehaviour
{
    public float Timeleft;
    public bool TimerOn = false;

    public Text TimerTxt;
    public void Start()
    {
        TimerOn = true;
    }


    void Update()
    {
        if(TimerOn)
        {
            if (Timeleft > 0)
            {
                Timeleft -= Time.deltaTime;
                updateTimer(Timeleft);
            }
            else
            {
                Debug.Log("Timer is up");
                Timeleft = 0;
                TimerOn = false;
                LoadNewScene();
            }
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("MainGame");
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

























}
