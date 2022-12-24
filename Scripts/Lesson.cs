
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lesson : MonoBehaviour
{
    public Text text;
    private Text myText;

    public bool selected;
    public bool actual;

    public LessonVariable.Lessons lesson;
    public LessonVariable.LessonsDuration duration;
    public LessonVariable.LessonsWeek week;

    public string professor = "";
    public string place ="";

    private SceneManager manager;

    private System.TimeSpan startDate;
    private System.TimeSpan endDate;

    public Lesson next;


    // Start is called before the first frame update
    void Start()
    {
        myText = this.gameObject.GetComponent<Text>();
        myText.text = "";
        if (lesson != LessonVariable.Lessons.NULL)
                myText.text = LessonVariable.LessonsToShortString(lesson) + " (" + place + ")";
        manager = Object.FindObjectOfType<SceneManager>();

        System.TimeSpan[] inifin = LessonVariable.LessonsDurationToDateTime(duration);

        startDate = inifin[0];
        endDate =   inifin[1];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        System.TimeSpan curent = new System.TimeSpan(System.DateTime.Now.Hour, System.DateTime.Now.Minute, 0);

        if (System.DateTime.Now.DayOfWeek == LessonVariable.LessonsWeekToDayOfWeek(week)) {

            if (curent > startDate && curent < endDate) {
                actual = true;
                Actual();
            }
        }

        if (selected)
        {
            Debug.Log(this.gameObject.GetComponentInParent<Button>().gameObject.name);
            UpdateInfoText();
            if(actual && selected)
                myText.color = Color.yellow;
        }


    }

    void UpdateInfoText() {
        string title_name = manager.ReadFromYaml(PathVariable.PathName.LESSONS, "lesson-name");
        string name = manager.ReadFromYaml(PathVariable.PathName.LESSONS, LessonVariable.LessonsToShortString(lesson));
        string title_place = manager.ReadFromYaml(PathVariable.PathName.LESSONS, "place");
        string title_teach = manager.ReadFromYaml(PathVariable.PathName.LESSONS, "teacher-name");
        string title_time = manager.ReadFromYaml(PathVariable.PathName.LESSONS, "time");

        string _week = manager.ReadFromYaml(PathVariable.PathName.LESSONS, LessonVariable.LessonsWeekToString(week));

        string text_to_show =
                  title_name  + ":" +
           "\n   " + name +

           "\n\n" + title_place+ ":" +
           "\n   " + place +

           "\n\n" + title_teach + ":" +
           "\n   " + professor +

           "\n\n" + title_time + ":" +
           "\n   " + _week + ", " + LessonVariable.LessonsDurationToString(duration);

        text.text = text_to_show;
    }

    public void clicked() {
        GameObject.FindObjectOfType<LessonManager>().NotifyClick(this);
        selected = true;
        myText.color = Color.red;
    }

    public void Actual()
    {
        GameObject.FindObjectOfType<LessonManager>().NotifyActual(this);
        actual = true;
        myText.color = Color.yellow;
    }

    public void NoActive() {
        selected = false;
        myText.color = Color.white;
    }

    public void NoActual()
    {
        actual = false;
        myText.color = Color.white;
    }

}
