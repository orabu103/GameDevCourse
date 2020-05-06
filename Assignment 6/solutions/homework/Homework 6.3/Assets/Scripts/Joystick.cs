using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform player;
    [SerializeField] public float speed = 3f;
    private bool touchOn = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public GameObject bulletPrefab; 
    public Transform innerCircle;
    public Transform outerCircle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        moveSpaceShip(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if(Input.GetKeyDown("space"))
        {
            shootBullet();
        }
        
        
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            innerCircle.transform.position = pointA * (-1);
            outerCircle.transform.position = pointA * (-1);
            innerCircle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (Input.GetMouseButton(0))
        {
            touchOn = true;
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchOn = false;
            innerCircle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void FixedUpdate()
    {
        if (touchOn)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveSpaceShip(direction * (-1));

            innerCircle.transform.position = new Vector2(pointA.x + direction.x, direction.y);

        }
    }

    //Moving the spaceship
    public void moveSpaceShip(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }

    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;

    }
}
