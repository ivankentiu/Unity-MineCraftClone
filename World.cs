﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    [SerializeField]
    private byte[,,] worldData;
    [SerializeField]
    private int worldX = 16;
    [SerializeField]
    private int worldY = 16;
    [SerializeField]
    private int worldZ = 16;

    // Use this for initialization
    void Start()
    {
        worldData = new byte[worldX, worldY, worldZ];

        for (int x = 0; x < worldX; x++)
        {
            for (int y = 0; y < worldY; y++)
            {
                for (int z = 0; z < worldZ; z++)
                {
                    if (y <= 8)
                    {
                        worldData[x, y, z] = (byte)TextureType.rock.GetHashCode();
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public byte Block(int x, int y, int z)
    {
        // if somebody passes outside the scope of the array that we created
        if (x >= worldX || x < 0 || y >= worldY || y < 0 || z >= worldZ || z < 0)
        {
            return (byte)TextureType.rock.GetHashCode();
        }

        return worldData[x, y, z];
    }
}