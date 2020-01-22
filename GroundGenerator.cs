using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{

    public GameObject[] groudPrefabs;
    public float maxHeight;
    public float minHeight;
    public float maxStep;  //maksymalny skok w góre , maksymalna wyoskos stopnia
    private float prevoiusGroundY = -2.47f;

    void Start()
    {
        InvokeRepeating("GenereteNewGround", 0, 2.5f); //ustawienia czasu prdukcji prefaba
    }

   
    void GenereteNewGround()
    {

        //tworzymy petle sprawdzająca czy platforma nie jest zbyt wysoko
        float newY;
        do
        {
            newY = Random.Range(-3f, 0.5f);

        } while (newY > maxStep + prevoiusGroundY);

        
        


        Vector3 targetPrefabPosition = new Vector3(this.transform.position.x,newY , this.transform.position.z);
        prevoiusGroundY = targetPrefabPosition.y;

        int IndexElemntu = Random.Range(0, groudPrefabs.Length);
        Instantiate(groudPrefabs[IndexElemntu], targetPrefabPosition, Quaternion.identity); //produkuje następna instacje prefaba
        Debug.Log(IndexElemntu);

    }
}
