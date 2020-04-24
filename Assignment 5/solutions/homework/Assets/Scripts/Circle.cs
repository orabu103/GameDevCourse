using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{

    [Tooltip("in meters per second")]
    [SerializeField] float radios = 10;

    [Tooltip("in meters per second")]
    [SerializeField] float rotate = 0; 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 1, 6);
     rotate = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rotate >= 360)
            {
                rotate = 0;
            }
            rotate = rotate - 150 * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, rotate, 0);
            transform.Translate(-(radios * Time.deltaTime), 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (rotate >= 360)
            {
                rotate = 0;
            }
            rotate = rotate + 150 * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, rotate, 0);
            transform.Translate(radios * Time.deltaTime, 0, 0);
        }
    
    }
}
