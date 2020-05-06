using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    
    public GameObject explosion; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag != "rocket")
        {
            Debug.Log("explotion");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
            //StartCoroutine( startDelay());
            LoadNextScene();
        }

    }
    private IEnumerator startDelay()
    {
        yield return new WaitForSeconds(5);
        

    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(++currentSceneIndex);
    }
}
