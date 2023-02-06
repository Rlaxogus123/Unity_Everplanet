using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    [SerializeField] List<GameObject> listTile = new List<GameObject>();
    [SerializeField] GameObject tempTile;
    [SerializeField] int xSize;
    [SerializeField] int ySize;

    void Start()
    {
        CreateMap();
    }

    void CreateMap()
    {
        for(int i = 0; i < xSize; i++)
        {
            for(int j = 0; j < ySize; j++)
            {
                GameObject obj = Instantiate(tempTile, transform);
                obj.transform.position = new Vector3((i - (xSize/2)) * 3, 0, (j - (ySize / 2)) * 3);
                obj.SetActive(true);

                listTile.Add(obj);
            }
        }
    }

    void Update()
    {
        
    }
}
