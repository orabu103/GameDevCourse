using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TimedSpawner: MonoBehaviour {
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 3f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 10f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in units")] [SerializeField] float maxXDistance = 9f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in units")] [SerializeField] float maxYDistance = 4.2f;




    void Start() {
        this.StartCoroutine(SpawnRoutine());
        Debug.Log("Start finished");
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3( Random.Range(-maxXDistance, +maxXDistance), (Random.Range(0, + maxYDistance))-2 , 0);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.transform.position = (positionOfSpawnedObject);
            timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(6);
            Destroy(newObject);
           
        }
    }
}
