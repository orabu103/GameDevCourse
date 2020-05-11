using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public float time = 4f;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _enemyBosPrefabs;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject _powerUpPrefabs;
    [SerializeField]
    private float positive = 8f;
    [SerializeField]
    private float negative = -8f;
    private int counter = 0;
    // Start is called before the first frame update 
    void Start()
    {
        StartCoroutine("SpawnEnemyRoutine");
        StartCoroutine(SpawnPowerUpRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnPowerUpRoutine()
    {
        while (true)
        {
            Vector3 postospawn = new Vector3(Random.Range(negative, positive), 13, 0);
            GameObject new_powerUp = Instantiate(_powerUpPrefabs, postospawn, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(10, 15));
        }
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {
            counter++;
            if (counter < 3)
            {
                Vector3 postospawn = new Vector3(Random.Range(negative, positive), 13, 0);
                GameObject new_enemy = Instantiate(_enemyPrefabs, postospawn, Quaternion.identity);
                new_enemy.transform.parent = _enemyContainer.transform;
                if (Time.time % 10 == 0)
                {
                    time /= 2;
                }
                yield return new WaitForSeconds(time);
            }
            else
            {
                counter = 0;
                Vector3 postospawn = new Vector3(Random.Range(negative, positive), 13, 0);
                GameObject new_enemy = Instantiate(_enemyBosPrefabs, postospawn, Quaternion.identity);
                new_enemy.transform.parent = _enemyContainer.transform;
                if (Time.time % 10 == 0)
                {
                    time /= 2;
                }
                yield return new WaitForSeconds(time);
            }
        }
    }


}
