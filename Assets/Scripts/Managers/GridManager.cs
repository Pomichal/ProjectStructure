using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private Tile tilePrefab;
    private Tile[,] tiles = new Tile[3, 7];
    public Tile[,] Tiles { get => tiles; }

    public float PlacableLerpSpeed { get => 20; }
    private void Awake()
    {
        App.gridManager = this;
    }
    private void Start()
    {
        CreateGrid();
    }
    private void CreateGrid()
    {
        for (int i = 0; i < tiles.GetLength(0); i++)
        {
            for (int j = 0; j < tiles.GetLength(1); j++)
            {
                tiles[i, j] = Instantiate(tilePrefab, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }
}
