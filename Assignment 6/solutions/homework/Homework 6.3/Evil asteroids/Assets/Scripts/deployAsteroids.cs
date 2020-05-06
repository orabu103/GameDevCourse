using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
   [SerializeField] public GameObject[] asteroPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(asteroWave());
    }

    private void spawnEnemy()
    {
        GameObject go = asteroPrefab[Random.Range(0, asteroPrefab.Length)];
        GameObject a = Instantiate(go) as GameObject;
        a.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + Random.Range(0, 11), 0);
    }

    IEnumerator asteroWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
