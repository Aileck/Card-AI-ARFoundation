using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekLabel : MonoBehaviour
{
    // Start is called before the first frame update
    public LessonVariable.LessonsWeek week;

    private Text myText;
    void Awake()
    {
        myText = this.GetComponent <Text>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myText.text = FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, LessonVariable.LessonsWeekToString(week));
    }
}
