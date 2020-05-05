using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallB : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" )
        {
            KeyboardMover player = collision.transform.GetComponent<KeyboardMover>();
            player.transform.position = new Vector3(player.transform.position.x, -4.5f, player.transform.position.z);
            Debug.Log("Wall");

        }
        if(collision.tag == "Circle")
        {
            Destroy(collision.gameObject);
        }
    }
}
