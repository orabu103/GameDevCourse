using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleW : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            KeyboardMover player = collision.transform.GetComponent<KeyboardMover>();
            if (player.transform.position.x > 10f)
            {
                player.transform.position = new Vector3(-10, player.transform.position.y, 0);

            }
            else if (player.transform.position.x < -10f)
            {
                player.transform.position = new Vector3(10, player.transform.position.y, 0);
            }
           
        }

        }
 }
  

