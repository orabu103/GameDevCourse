using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange2 : MonoBehaviour
{

    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    bool b = false;

    // Start is called before the first frame update
    void Start()
    {
        camera1.gameObject.active = true;
        camera2.gameObject.active = false;
    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!b)
            {
                camera1.gameObject.active = false;
                camera2.gameObject.active = true;
                b = true;
            }
            else if (b)
            {
                camera1.gameObject.active = true;
                camera2.gameObject.active = false;
                b = false;
            }
        }
    }
}
