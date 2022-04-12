using System;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [Serializable]
    internal sealed class PlayerSettingsData
    {
        [Header("�������� ������")]
        public Material PlayerMaterial;
        [Header("Spawn Point"), Space(10)]
        public Transform SpawnPoint;
    }
}
