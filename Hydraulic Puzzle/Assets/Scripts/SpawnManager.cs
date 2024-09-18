using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject item;
    public Vector3 spawnPosition = new Vector3(-3,2,0);

    public bool spawning = true;
    private GameObject objectToBeDestroyed;

    private void Update()
    {
        if (objectToBeDestroyed == null) 
        { 
            Spawn();
            spawning = true;
        }
 
        
    }
    private void Spawn()
    {
        if (spawning == true)
        {
           objectToBeDestroyed = Instantiate(item, spawnPosition, item.transform.rotation);
            
            spawning= false;
        }
    }



}
