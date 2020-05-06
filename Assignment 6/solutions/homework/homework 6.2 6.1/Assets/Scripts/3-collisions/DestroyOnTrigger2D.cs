using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int health = 3;
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled)
        {
            if (this.tag == "Player")
            {
                health--;
                Destroy(other.gameObject);
            }


            else
            {
                Destroy(this.gameObject);
                Destroy(other.gameObject);
            }
        }
    }
    private void Update()
    {
        if (health == 0)
        {
            star1.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
        else if(health == 2)
        {
            star3.gameObject.SetActive(false);
        }
        else if(health == 1)
        {
            star2.gameObject.SetActive(false);
        }
    }
}

