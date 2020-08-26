using System;
using UnityEngine;

public class PillCollector : MonoBehaviour
{
    GameObject myPill;
    public Action onCollected;
    private void OnTriggerEnter(Collider other)
    {
        //wenn der Ball eine der Pillen berührt, dann wird sie eingesammelt
        if (other.CompareTag($"Ball"))
        {
            Collect();
        }
    }

    private void Collect()
    {
        myPill = GameObject.FindWithTag ("Capsule");
        onCollected?.Invoke();
        Destroy(myPill); //nach dem einammeln wird das Pillen-Klon-Objekt gelöscht
      
    }

}



