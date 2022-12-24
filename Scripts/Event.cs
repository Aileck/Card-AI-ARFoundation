using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
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
        text.text = FindObjectOfType<SceneManager>().ReadFromYaml(PathVariable.PathName.LESSONS, "event-if-void");
    }
}
