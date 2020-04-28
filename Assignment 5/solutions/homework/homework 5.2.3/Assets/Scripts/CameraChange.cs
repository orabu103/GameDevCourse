using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    [SerializeField] Camera camera1;
    [SerializeField] Camera camera2;
    bool b = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
   
    void Update()
    {
            if (Input.GetKey(KeyCode.M))
             {
                if (!b) { 
                     camera1.gameObject.active = false;
                    camera2.gameObject.active = true;
                    b = true;
                }
                else if (b) { 
                    camera1.gameObject.active = true;
                    camera2.gameObject.active = false;
                    b = false;
                }
            }
    }
}
