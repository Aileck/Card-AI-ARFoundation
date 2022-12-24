using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    // Start is called before the first frame update
    float radian = 0; 
    float perRadian = 0.02f; 
    float radius = 0.04f; 
    Vector3 oldPos; 

    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = transform.position; // Ini pos


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (move == true)
        {
            radian += perRadian; // Rad 0.03
            float dy = Mathf.Cos(radian) * radius; 
            transform.position = oldPos + new Vector3(0, dy, 0);
        }
        else
        {
            //print("paro");
            Start();
        }
    }
}
