using System.IO;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    [CreateAssetMenu(menuName = "Data/Data", fileName = "Data", order = 51)]
    internal sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _platformDataPath;
        [SerializeField] private string _scoreDataPath;

        private PlayerData _playerData;
        private PlatformData _platformData;
        private ScoreData _scoreData;

        internal PlatformData PlatformData
        {
            get
            {
                if (_platformData == null)
                {
                    _platformData = Resources.Load<PlatformData>(Path.Combine(ManagerPath.DATA, ManagerPath.ENVIRONMENT,
                        ManagerPath.PLATFORM, ManagerName.PLATFORM_DATA));

                    if (_platformData == null)
                    {
                        _platformData = Resources.Load<PlatformData>(Path.Combine(ManagerPath.DATA, _platformDataPath));
                    }
                }
                return _platformData;
            }
            set => _platformData = value;
        }

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

        internal ScoreData ScoreData
        {
            get
            {
                if (_scoreData == null)
                {
                    _scoreData = Resources.Load<ScoreData>(Path.Combine(ManagerPath.DATA, ManagerPath.UI, ManagerPath.SCORE));
                }
                return _scoreData;
            }
            set => _scoreData = value;
        }
    }
}