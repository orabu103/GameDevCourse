using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float asteroidSpeed = 2f;
    private Rigidbody2D rigidbody;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        transform.Translate(Vector3.left * asteroidSpeed * Time.deltaTime);

        if (transform.position.x < -screenBounds.x)
        {
            Destroy(this.gameObject);
        }
    }
}
