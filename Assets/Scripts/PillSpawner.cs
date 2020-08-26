using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] pillPrefab;
    public GameObject[] pillClone;
    private int amount = 0;
    void Start()
    {
        SpawnPill();
    }
    
    void SpawnPill()
    {
        for (var i = 0; i < 5; i++)
        {
            //die Pillen-Klone werden als Kind-Obejekte des Spawners gespawnt
            //dadurch beiben sie Kind-Objekte des Spielfeldes und bewegen sich mit ihm mit
            pillClone[i] = Instantiate(pillPrefab[i], spawnLocations[i].transform.position, transform.rotation, transform.parent);
            //sobald die Pille im PillCollector eingesammelt worden ist, erhöht sich die Pillenmenge um die eingeammelte Pille
            pillClone[i].GetComponent<PillCollector>().onCollected += OnCollected;
            
        }
    }

    //wenn eine Pille eingesammelt wurde, erhöht sich die Pillenmenge um 1
    private void OnCollected()
    {
        amount += 1;
    }
    
    //getter Methode zur Abfrage der Pillenmenge
    public int GetPillAmount()
    {
        return amount;
    }
}
