﻿// 
// 2023/11/29

using Sirenix.OdinInspector;
using UnityEngine;

namespace SquareHero.Hotfix.Map
{
    [CreateAssetMenu(fileName = "Tile", menuName = "SquareHero/Map/Tile", order = 0)]
    public class TileAsset : SerializedScriptableObject
    {
        public TileData tileData;
        public GameObject prefab;
    }



    public enum TileType
    {
        Ground = 0,
        Water,
        Cliff,
        Flight,
        Start = 1000,
        End = 1001
    }

    public enum TilePosition
    {
        Start = 0,
        End = 1,
        Middle,
    }
}