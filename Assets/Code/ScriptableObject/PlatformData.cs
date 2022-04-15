using UnityEngine;

namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(fileName = "PlatformData", menuName = "Data/PlatformData", order = 51)]
    public sealed class PlatformData : ScriptableObject
    {
        public GameObject PlatformPrefab;
    }
}