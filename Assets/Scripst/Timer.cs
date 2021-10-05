using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeStart; //начало отсчета
    public Text timerText; //отображаемый текст
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString(); //отображение стартового времени
    }

    // Update is called once per frame
    void Update()
    {
         timeStart -= Time.deltaTime; //отнимает 1 сек
         timerText.text = Mathf.Round(timeStart).ToString(); //отображение только целых чисел
         if(timeStart < 0)
         {
            HealthBar.aimDestr = 0;
            SceneManager.LoadScene("Lose");
            HealthBar.LooseScore++;
         }
    }
}
