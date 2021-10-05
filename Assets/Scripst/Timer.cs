using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeStart; //������ �������
    public Text timerText; //������������ �����
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStart.ToString(); //����������� ���������� �������
    }

    // Update is called once per frame
    void Update()
    {
         timeStart -= Time.deltaTime; //�������� 1 ���
         timerText.text = Mathf.Round(timeStart).ToString(); //����������� ������ ����� �����
         if(timeStart < 0)
         {
            HealthBar.aimDestr = 0;
            SceneManager.LoadScene("Lose");
            HealthBar.LooseScore++;
         }
    }
}
