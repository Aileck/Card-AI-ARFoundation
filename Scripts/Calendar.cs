using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calendar : MonoBehaviour
{
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DayOfWeek week = DateTime.Now.DayOfWeek;
        int min = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;
        int sec = DateTime.Now.Second;

        string text_to_show =

           hour.ToString () + " : " + min.ToString() + " : " + sec.ToString();

        text.text = text_to_show;



    }
}
