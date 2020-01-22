using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTransmitter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenCurrentLevel()
    {
       GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }

    public void CloseAplication()
    {
        PlayerPrefs.SetInt("currentLevel", GameManager.instance.currentLevel); //zapis gry
        PlayerPrefs.Save();

        Application.Quit();
    }
}
