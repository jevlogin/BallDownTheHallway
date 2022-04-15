using UnityEngine;

namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(menuName = "Data/ScoreData", fileName = "ScoreData", order = 51)]
    internal sealed class ScoreData : ScriptableObject
    {
        [Header("Префаб UI очки/жизни")]
        public ScoreView ScoreViewPrefab;
    }
}