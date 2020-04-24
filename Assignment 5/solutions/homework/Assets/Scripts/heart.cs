using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("in meters per second")]
    [SerializeField] float speed = 3;

    [Header("Oscillation - Amplitude & Direction")]
    public Vector3 oscillationVector;
    private Vector3 oldPos;
    public float deltaPhase =  Mathf.PI;

    void Start()
    {
        oldPos = transform.localScale;
        oscillationVector = oldPos;
    }

    // Update is called once per frame
    void Update()
    {
        uint i = 0;
        float phase = speed * Time.time + i * deltaPhase ;
        transform.localScale = oldPos + oscillationVector * (Mathf.Sin(phase) + 4) ;
        i++;

    }
}
