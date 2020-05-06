using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public GameObject explosion; 
    private readonly int DESTROY_BOUND = 10; 
    GameObject spaceShip; 
    private Rigidbody2D rigidbody;
    private Vector2 screenBounds; 

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(speed, 0);
        //this.transform.position = new Vector3(spaceShip.transform.position.x, spaceShip.transform.position.y, spaceShip.transform.position.z);
        screenBounds =  Camera.main.ScreenToWorldPoint(new Vector3(Screen.width + 300, Screen.height, Camera.main.transform.position.z ));
        //transform.Translate(Vector3.left * speed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > DESTROY_BOUND)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if(other.tag == "brown" || other.tag == "white" || other.tag == "purple")
        {
            print("HIT!!!!!");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            this.gameObject.SetActive(false);
        }
    }
}
