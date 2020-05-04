using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClimber : MonoBehaviour
{
    [Tooltip("Direction and speed of movement, in units per second")]
    [SerializeField] Vector3 speed;

    void Update() {
        transform.position += speed * Time.deltaTime;

        if (transform.position.x > 10f)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -10f)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Quaternion rotation = Quaternion.Euler(0, 0, 90);   // 90 degrees leftwards (around Z axis)
        speed = rotation * speed;       // rotate the speed vector
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Quaternion rotation = Quaternion.Euler(0, 0, 90);   // 90 degrees leftwards (around Z axis)
        speed = rotation * speed;       // rotate the speed vector
    }
}
