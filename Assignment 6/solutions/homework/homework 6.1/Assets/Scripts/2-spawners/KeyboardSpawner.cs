using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component spawns the given object whenever the player clicks a given key.
 */
public class KeyboardSpawner: MonoBehaviour {
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    [SerializeField] private GameObject PowerShot;
    [SerializeField] protected GameObject Shield;
    private bool PowerShotActivty = false;
    private bool ShieldActivty = false;
    private GameObject newObject; 
    [SerializeField]  int maxY = 2;



    protected virtual GameObject spawnObject() {
        // Step 1: spawn the new object.
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        if (!PowerShotActivty)
            {
                 newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);
        }
         else
            {
                newObject = Instantiate(PowerShot, positionOfSpawnedObject, rotationOfSpawnedObject);
            }
        // Step 2: modify the velocity of the new object.
        Mover newObjectMover = newObject.GetComponent<Mover>();
        if (newObjectMover) {
            newObjectMover.SetVelocity(velocityOfSpawnedObject);
        }
        
        return newObject;
    }

    private void Update() {
        if (Input.GetKeyDown(keyToPress)) {
            spawnObject();
            
        }
    }

    public void TripleShotActive()
    {
        PowerShotActivty = true;
        StartCoroutine(TripleShotRoutine());
    }


    IEnumerator TripleShotRoutine()
    {
        yield return new WaitForSeconds(5f);
        PowerShotActivty = false;
       
    }

    public void SheildRoutine()
    {
        ShieldActivty = true;
        if (ShieldActivty)
        {
            Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
            Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
            newObject = Instantiate(Shield, positionOfSpawnedObject, rotationOfSpawnedObject);
            Mover newObjectMover = newObject.GetComponent<Mover>();
            if (newObjectMover)
            {
                newObjectMover.SetVelocity(velocityOfSpawnedObject);
            }

        }
        StartCoroutine(SheildRoutinelow(newObject));
        
     
    }

        private IEnumerator SheildRoutinelow(GameObject Shiel)
        {
        
        for (float i = 5; i > 0; i--)
        {
            
            Debug.Log("Shield: " + i + " seconds remaining!");
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Shield gone!");
        ShieldActivty = false;
        Destroy(Shiel);
      }
    }
