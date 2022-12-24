using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;

            if (Physics.Raycast(ray, out hitinfo))
            {

                //Si nºdedo = 1 y primer contacto
                if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
                {


                    //Doble click
                    if (Input.GetTouch(0).tapCount == 2)
                    {
                        Destroy(hitinfo.collider.gameObject);
                    }

                }
            }
        }
    }
}
