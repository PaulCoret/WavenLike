using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile tilePrefab;

    void Start()
    {
        GenerateGrid();
    }
    void GenerateGrid()
    {
     
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {

                var spawnedTile = Instantiate(tilePrefab, new Vector2(x, z), Quaternion.identity);
                spawnedTile.name = $"Tile {x}, {z}";

                var isOffset = (x % 2 == 0 && z % 2 != 0) || (x % 2 != 0 && z % 2 == 0);
                spawnedTile.Init(isOffset);

              
            }
        }
    }
}
