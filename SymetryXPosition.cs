using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymetryXPosition : MonoBehaviour
{
    //skryp płynnego poruszania się obiektu
    public GameObject hero;

    Vector3 curretntPosition;
    Vector3 targetPosition;
    public float randomYMax;
    public float randomYmin;

    float startTime;
    private float currentTime;

    void Start()
    {
        startTime = Time.time;
        InvokeRepeating("SetNewPosition", 0, 1); //co jaki czas funkcja ma byc wykonywana 
    }

    
    void Update()
    {
        currentTime = Time.time - startTime;
        transform.position = Vector3.Slerp(curretntPosition, targetPosition, currentTime );

        
    }

    void SetNewPosition()
    {
        curretntPosition = transform.position; //zapis nowej pozycji
        targetPosition = new Vector3(Mathf.Abs(hero.transform.position.x), Random.Range(randomYmin, randomYMax), transform.position.z); //sprawdzenie poyzcji
        startTime = Time.time;
    }
}
