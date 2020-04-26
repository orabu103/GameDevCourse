using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{

    [Tooltip("in meters per second")]
    [SerializeField] float speed = 3;

    [Header("Oscillation - Amplitude & Direction")]
    public Vector3 oscillationVector;

    private Vector3 oldPos;
    public float deltaPhase = 2 * Mathf.PI;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        oscillationVector = new Vector3(6, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        uint i = 0;
        float phase = speed * Time.time + i * deltaPhase ;
        transform.position = oldPos + oscillationVector  * Mathf.Sin(phase);
        i++;
    }
}
