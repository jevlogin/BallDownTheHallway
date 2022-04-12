using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [Serializable]
    internal sealed class PlayerSettingsData
    {
        [Header("Материал игрока")]
        public Material PlayerMaterial;
        [Header("Spawn Point"), Space(10)]
        public Transform SpawnPoint;
    }
}
