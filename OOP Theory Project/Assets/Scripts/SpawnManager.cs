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


    // Start is called before the first frame update
    void Start()
    {

        Invoke(nameof(InstantiatePrefabs), 2);


    }

    void InstantiatePrefabs () {
        Instantiate(platform, platform.transform.position, platform.transform.rotation);

        Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);
        Instantiate(enemyMorph, enemyMorph.transform.position, enemyMorph.transform.rotation);
       
        Instantiate(heartToken, heartToken.transform.position, heartToken.transform.rotation);
        Instantiate(starToken, starToken.transform.position, starToken.transform.rotation);

        Invoke(nameof(InstantiatePrefabs), 2);
    }
}
