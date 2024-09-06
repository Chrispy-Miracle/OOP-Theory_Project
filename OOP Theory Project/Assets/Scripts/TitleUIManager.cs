using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    public void LoadGame(GameObject chosenPlayer) {
        MainManager.Instance.playerChoice = chosenPlayer;
        SceneManager.LoadScene(1);
    }
}
