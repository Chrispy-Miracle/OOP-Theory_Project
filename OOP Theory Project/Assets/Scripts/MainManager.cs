using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // public get, but can only be set inside this class
    public static MainManager Instance { get; private set; }

    public GameObject playerChoice = null; // will be player character
    
    private void Awake()
    {
        if (Instance != null)  // singleton
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
