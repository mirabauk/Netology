using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderGen : MonoBehaviour
{
    public Transform Player;
    public Border[] BorderPrefabs;
    public Border FirstBorder;

    private List<Border> spawnedBorders = new List<Border>();

    private void Start()
    {
        spawnedBorders.Add(FirstBorder);
    }

    private void Update()
    {
        if (Player.position.z > spawnedBorders[spawnedBorders.Count - 1].EndBorder.position.z - 90)
        {
            SpawnBorder();
        }
    }

    private void SpawnBorder()
    {
        Border newBorder = Instantiate(BorderPrefabs[Random.Range(0, BorderPrefabs.Length)]);
        newBorder.transform.position = spawnedBorders[spawnedBorders.Count - 1].EndBorder.position - newBorder.BeginBorder.localPosition;
        spawnedBorders.Add(newBorder);
    }

}