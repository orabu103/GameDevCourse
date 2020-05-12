﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public float time = 4f;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject _powerUpPrefabs;
    [SerializeField]
    private float positive = 8f;
    [SerializeField]
    private float negative = -8f;
    private bool Bigcow = false;
    private int _countbigcow;
    [SerializeField] GameObject bigCowObject;

    // Start is called before the first frame update 
    void Start()
    {
        StartCoroutine(SpawnEnemyRoutine());
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
            if (!Bigcow)
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
                while (_countbigcow > 0)
                {
                    Debug.Log("big");
                    Vector3 postospawn = new Vector3(Random.Range(negative, positive), 13, 0);
                    GameObject new_enemy = Instantiate(bigCowObject, postospawn, Quaternion.identity);
                    new_enemy.transform.parent = _enemyContainer.transform;
                    if (Time.time % 10 == 0)
                    {
                        time /= 2;
                    }
                    Bigcow = false;
                    yield return new WaitForSeconds(time);
                    _countbigcow--;
                }
                Bigcow = false;
            }
        }
    }
    public void setBigCaw(int cow)
    {
        FindObjectOfType<AudioManager>().Play("police");
             _countbigcow = cow;
            Bigcow = true;
    }
}
