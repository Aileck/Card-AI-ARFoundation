
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonManager : MonoBehaviour
{
    // Start is called before the first frame update
    //public Lesson[] lessons = GameObject.FindObjectsOfType<Lesson>();
    public Lesson current;
    public Lesson actual;

    public Lesson next;
    public Text next_text;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (current == null && actual != null)
            actual.clicked();


        if (next != null) {
            string text_to_show =
                 "- " + FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, "until") + " -" +

           "\n" + FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, LessonVariable.LessonsToShortString(next.lesson)); ;

            next_text.text = text_to_show;
        }
        else
        {
            string text_to_show =
                "- " + FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, "until") + " -" +

                "\n" + FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, "NULL") ;

            next_text.text = text_to_show;
        }
    }

    public void NotifyClick(Lesson l) {
        if(current != null)
            current.NoActive();
        current = l;
    }

    public void NotifyActual(Lesson l)
    {
        if(actual != null)
            actual.NoActual();
        actual = l;
        next = l.next;
    }
}
