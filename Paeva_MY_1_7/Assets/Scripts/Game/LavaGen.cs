using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaGen : MonoBehaviour
{
    public Transform Player;
    public Lava[] LavaPrefabs;
    public Lava FirstLava;
    private Lava lastSpawnedLava;

    //private List<Lava> spawnedLavas = new List<Lava>();

    private void Start()
    {
        //spawnedLavas.Add(FirstLava);
        lastSpawnedLava = FirstLava;
    }

    private void Update()
    {
        if (Player.position.z > lastSpawnedLava.EndLava.position.z - 95)
        {
            SpawnLava();
        }
    }

    public void SpawnLava()
    {
        Lava newLava = Instantiate(LavaPrefabs[Random.Range(0, LavaPrefabs.Length)]);
        newLava.transform.position = lastSpawnedLava.EndLava.position - newLava.BeginLava.localPosition;
        lastSpawnedLava = newLava;
        //Destroy(newLava, 10f);
        //spawnedLavas.Add(newLava);
    }
}