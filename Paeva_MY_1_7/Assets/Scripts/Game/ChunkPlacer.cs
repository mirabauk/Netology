using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ChunkPlacer : MonoBehaviour
{
    public Transform Player;
    public Transform Chunk;
    public Chunk[] ChunkPrefabs;
    public Chunk FirstChunk;
    public Chunk FirstChunkL;
    public Chunk FirstChunkR;
    public float minY = -1;
    public float maxY = 3;
    public Obstacle[] ObstaclePrefabs;

    private List<Chunk> spawnedChunks = new();
    private List<Chunk> spawnedLeftChunks = new();
    private List<Chunk> spawnedRightChunks = new();

    private void Start()
    {
        spawnedChunks.Add(FirstChunk);
        spawnedLeftChunks.Add(FirstChunkL);
        spawnedRightChunks.Add(FirstChunkR);
    }

    private void Update()
    {
        SpawnRoad();
    }

    private void GenerateObstacles(List<Chunk> chunksList)
    {
        var position = chunksList.Count - 3;
        if (position < 0 || Random.Range(0,3) < 2) return;

        Obstacle newObstacle = Instantiate(ObstaclePrefabs[Random.Range(0, ObstaclePrefabs.Length)]);
        newObstacle.transform.position = new Vector3(x: chunksList[position].End.position.x, y: chunksList[position].End.position.y + 1, z: chunksList[position].End.position.z - 2);
    }

    private void SpawnRoad()
    {
        if (Player.position.z > spawnedChunks[^1].End.position.z - 75)
        {
            SpawnChunk(spawnedChunks);
            GenerateObstacles(spawnedChunks);
        }
        if (Player.position.z > spawnedLeftChunks[^1].End.position.z - 75)
        {
            SpawnChunk(spawnedLeftChunks);
            GenerateObstacles(spawnedLeftChunks);
        }
        if (Player.position.z > spawnedRightChunks[^1].End.position.z - 75)
        {
            SpawnChunk(spawnedRightChunks);
            GenerateObstacles(spawnedRightChunks);
        }
    }

    private void SpawnChunk(List<Chunk> chunksList)
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = chunksList[^1].End.position - newChunk.Begin.localPosition;
        if (newChunk.transform.position.y > maxY)
        {
            newChunk.transform.position = new Vector3(x: newChunk.transform.position.x, y: maxY, z: newChunk.transform.position.z);
        }
        if (newChunk.transform.position.y < minY)
        {
            newChunk.transform.position = new Vector3(x: newChunk.transform.position.x, y: minY, z: newChunk.transform.position.z);
        }
        chunksList.Add(newChunk);
    }
}