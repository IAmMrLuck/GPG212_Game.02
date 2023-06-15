
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelSpawner : MonoBehaviour
{

    [SerializeField] private GameObject jewelToSpawn;
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private Transform placeToSpawn;


    public void SpawnTheGem()
    {
        GameObject currentGem = Instantiate(jewelToSpawn, placeToSpawn);
        currentGem.transform.position = placeToSpawn.position;

    }


}
