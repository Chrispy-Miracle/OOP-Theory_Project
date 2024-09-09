using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject platform;
    public GameObject enemy;
    public GameObject enemyMorph;
    public GameObject heartToken;
    public GameObject starToken;

    private float platformYRange = 1.5f;

    private float spawnXModifier = 15.0f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnPlatforms), 1);
        StartCoroutine(SpawnOnGround());
    }

    IEnumerator SpawnOnGround() {
        while (true) {
            float delay = Random.Range(1, 3);
            SpawnRandomGameObject(0.0f);
            Debug.Log("coroutine happening");
            yield return new WaitForSeconds(delay);
        }
        
    }


    void SpawnPlatforms() {
        float yPosition = Random.Range(-platformYRange, platformYRange);
        SpawnGameObject(platform, yPosition);

        SpawnRandomGameObject(yPosition + platform.transform.position.y + .5f);

        Invoke(nameof(SpawnPlatforms), Random.Range(2.5f, 3.5f));
    }


    void SpawnRandomGameObject(float yPosition) {
        int randomInt = Random.Range(0, 4);
        
        switch (randomInt) {
            case 0:
                SpawnGameObject(enemy, yPosition);
                break;
            case 1:
                SpawnGameObject(enemyMorph, yPosition);
                break;
            case 2:
                SpawnGameObject(starToken, yPosition);
                break;
            case 3:
                SpawnGameObject(heartToken, yPosition);
                break;
            default:
                break;             
        }
    }


    void SpawnGameObject(GameObject prefab, float yPosition) {
        Vector3 positionModifier = new Vector3(spawnXModifier, yPosition, 0);

        Instantiate(prefab, prefab.transform.position + positionModifier, prefab.transform.rotation);
    }

}
