using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSide : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("In units per second")]
    [SerializeField] float speed = 50.0f;   // in units per second
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
