using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    public void LoadGame(GameObject chosenPlayer) {
        MainManager.Instance.playerChoice = chosenPlayer; // sets player choice for main scene
        SceneManager.LoadScene(1); // main scene
    }
}
