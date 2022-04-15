using UnityEngine;

namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(menuName = "Data/PlayerData", fileName = "PlayerData", order = 51)]
    internal sealed class PlayerData : ScriptableObject
    {
        #region Fields

        [Header("Свойства игрока:"), Space(20)] 
        public PlayerStruct PlayerStruct;
        [Header("Содержит компоненты."), Space(20)] 
        public PlayerComponents PlayerComponents;
        [Header("Содержит всевозможные настройки для игрока."), Space(20)] 
        public PlayerSettingsData PlayerSettingsData;

        #endregion
    } 
}