using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(menuName = "Data/Data", fileName = "Data", order = 51)]
    internal sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;

        private PlayerData _playerData;

        internal PlayerData PlayerData
        {
            get
            {
                if (_playerData == null)
                {
                    _playerData = Resources.Load<PlayerData>(Path.Combine(ManagerPath.DATA, ManagerPath.PLAYER, ManagerName.PLAYER_DATA));
                    if (_playerData == null)
                    {
                        _playerData = Resources.Load<PlayerData>(Path.Combine(ManagerPath.DATA, _playerDataPath));
                    }
                    if (_playerData.PlayerComponents == null)
                    {
                        _playerData.PlayerComponents = new PlayerComponents();
                    }
                }
                return _playerData;
            }

            set => _playerData = value;
        }
    }
}