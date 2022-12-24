using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject cube;
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

            if (Physics.Raycast(ray, out hitinfo) && hitinfo.transform.tag == "map")
            {
                Debug.Log("hitinfo");
                cube.transform.position = new Vector3(
                            hitinfo.point.x,
                            hitinfo.point.y + 0.01f,
                            hitinfo.point.z
                        );

            }
        }
    }
}

