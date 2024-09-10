using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Platform;
    public GameObject Enemy;
    public GameObject EnemyMorph;
    public GameObject HeartToken;
    public GameObject StarToken;

    private float platformYRange = 1.5f; 

    private float spawnXModifier = 15.0f; // x-axis offset


    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnPlatforms), 1);
        StartCoroutine(SpawnOnGround());
    }

    // ABSTRACTION
    IEnumerator SpawnOnGround() {  // spawn random on ground
        while (true) {
            float delay = Random.Range(1, 3);
            SpawnRandomGameObject(0.0f);
            Debug.Log("coroutine happening");
            yield return new WaitForSeconds(delay);
        }
    }

    // ABSTRACTION
    void SpawnPlatforms() {
        float yPosition = Random.Range(-platformYRange, platformYRange);
        SpawnGameObject(Platform, yPosition);
        
        // spawn random on platform
        SpawnRandomGameObject(yPosition + Platform.transform.position.y + .5f);
        // repeat
        Invoke(nameof(SpawnPlatforms), Random.Range(2.5f, 3.5f));
    }

    // ABSTRACTION
    void SpawnRandomGameObject(float yPosition) {
        int randomInt = Random.Range(0, 4);
        
        switch (randomInt) {
            case 0:
                SpawnGameObject(Enemy, yPosition);
                break;
            case 1:
                SpawnGameObject(EnemyMorph, yPosition);
                break;
            case 2:
                SpawnGameObject(StarToken, yPosition);
                break;
            case 3:
                SpawnGameObject(HeartToken, yPosition);
                break;
            default:
                break;             
        }
    }

    // ABSTRACTION
    void SpawnGameObject(GameObject prefab, float yPosition) {
        Vector3 positionModifier = new Vector3(spawnXModifier, yPosition, 0);

        Instantiate(prefab, prefab.transform.position + positionModifier, prefab.transform.rotation);
    }

}
