using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCams : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    bool b = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !b)
        {
            camera1.gameObject.active = false;
            camera2.gameObject.active = true;
            b = true;
        }
        else if (Input.GetMouseButtonDown(0) && b)
        {
            camera1.gameObject.active = true;
            camera2.gameObject.active = false;
            b = false;
        }
    }
}
