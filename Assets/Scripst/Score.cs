using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    GUIStyle font;

    void Start()
    {
        font = new GUIStyle();
        font.fontSize = 50;
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(610, 510, 300, 60), "Victories: " + HealthBar.WinScore, font);
        GUI.Label(new Rect(610, 590, 300, 60), "Defeats: " + HealthBar.LooseScore, font);
    }
}
