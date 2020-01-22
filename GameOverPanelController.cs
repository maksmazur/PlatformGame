using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelController : MonoBehaviour
{
    
    void Start()
    {
        
    }

   public void LoadLevelAgain()
    {
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }
    public void LoadNextAgain()
    {
        GameManager.instance.currentLevel++;
        if (GameManager.instance.currentLevel < GameManager.instance.levelNames.Length )
        {
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        else // mozemy pozniej dac info o ukonczonej grze.
        {
            GameManager.instance.currentLevel = 0;
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);

        }
    }
    public void LoadManu()
    {
        SceneManager.LoadScene("Menu");
    }
}
