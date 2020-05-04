using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protector : MonoBehaviour
{

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] float radius;



    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == triggeringTag && enabled)
        {
            var increment = 10;
            for (int angle = 0; angle < 360; angle = angle + increment)
            {
                var point = this.gameObject.transform.position + Quaternion.Euler(0, angle, 0) * Vector3.forward * radius;
                var point2 = this.gameObject.transform.position + Quaternion.Euler(0, angle + increment, 0) * Vector3.forward * radius;
                Debug.DrawLine(point, point2, Color.red);
            }
        }
    }
}
