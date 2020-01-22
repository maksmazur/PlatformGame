using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{

    private GameObject successPanel;
    private GameObject failPanel;
    private GameObject gameOverCanvas;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas = GameObject.Find("GameOverCanvas");
        if (gameOverCanvas !=null)
        {
            failPanel = gameOverCanvas.transform.GetChild(0).gameObject;
            successPanel = gameOverCanvas.transform.GetChild(1).gameObject;
        }
    }


    private void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.tag == "balloon")
        {

            Debug.Log("Sukces!");
            successPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (other.gameObject.tag == "border")
        {
            Debug.Log("Porazka");
            failPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
