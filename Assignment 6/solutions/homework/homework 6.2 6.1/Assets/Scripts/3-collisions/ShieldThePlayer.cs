using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldThePlayer : MonoBehaviour {
    [Tooltip("The number of seconds that the shield remains active")] [SerializeField] float duration;
  

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player")
        {
            KeyboardSpawner player = other.transform.GetComponent<KeyboardSpawner>();
            if (this.tag == "Power")
            {
                Debug.Log("Power triggered by player");
                if (player != null)
                    player.TripleShotActive();
                Destroy(this.gameObject);  // Power the shield itself - prevent double-use q
            }
            if (this.tag == "Shield")
            {
                if (player != null)
                    player.SheildRoutine();
                Destroy(this.gameObject);  // Power the shield itself - prevent double-use
            }
        }
 
        
    }
    private IEnumerator ShieldTemporarily(DestroyOnTrigger2D destroyComponent) {
      
        destroyComponent.enabled = false;
        for (float i = duration; i > 0; i--) {
            Debug.Log("Shield: " + i + " seconds remaining!");
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Shield gone!");
        destroyComponent.enabled = true;
    }

}
