using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int currentLevel = 0;

    public string[] levelNames;

     void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {
        if (PlayerPrefs.HasKey("currentLevel"))
        {
            currentLevel =  PlayerPrefs.GetInt("currentLevel");
        }
       
    }
    public void OpenLevel(int newLevelNum)
    {
        SceneManager.LoadScene(levelNames[newLevelNum]);
    } 
    public void OpenCurrentLevel()
    {
        OpenLevel(currentLevel);
    }
    public void CloseAplication()
    {
        PlayerPrefs.SetInt("currentLevel", currentLevel); //zapis gry
        PlayerPrefs.Save();

        Application.Quit();
    }
}
