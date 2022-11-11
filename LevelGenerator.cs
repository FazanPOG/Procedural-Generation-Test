using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Chunk[] chunksPrefabs;
    [SerializeField] private Chunk firstChunk;
    [SerializeField] private int levelSize;


    private List<Chunk> chunksIsSpawned = new List<Chunk>();

    private void Start()
    {
        
        chunksIsSpawned.Add(firstChunk);

        for (int i = 0; i < levelSize; i++)
        {
            SpawnChunk();
        }
    }


    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(chunksPrefabs[Random.Range(0, chunksPrefabs.Length)]);
        newChunk.transform.position = chunksIsSpawned[chunksIsSpawned.Count - 1].right.position - newChunk.left.localPosition * newChunk.transform.localScale.x;

        chunksIsSpawned.Add(newChunk);
    }
}
