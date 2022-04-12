using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class PlayerFactory
    {
        private readonly PlayerData _playerData;
        private PlayerModel _playerModel;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        internal PlayerModel CreatePlayerModel()
        {
            if (_playerModel == null)
            {
                var playerStruct = _playerData.PlayerStruct;
                var playerComponents = _playerData.PlayerComponents;
                var playerSettings = _playerData.PlayerSettingsData;

                var spawnPlayer = CreatePlayer();

                spawnPlayer.GetComponent<MeshRenderer>().sharedMaterial =
                    playerSettings.PlayerMaterial;
                spawnPlayer.transform.position = 
                    _playerData.PlayerSettingsData.SpawnPoint.position;

                playerComponents.ColliderPlayer = spawnPlayer.GetOrAddComponent<Collider>();
                playerComponents.TransformPlayer = spawnPlayer.GetOrAddComponent<Transform>();
                playerComponents.RigidbodyPlayer = spawnPlayer.GetOrAddComponent<Rigidbody>();

                _playerModel = new PlayerModel(playerStruct, playerComponents, playerSettings);
            }
            return _playerModel;
        }

        private GameObject CreatePlayer()
        {
            var player = GameObject.CreatePrimitive(PrimitiveType.Sphere)
                .AddSphereCollider()
                .AddRigidbody()
                .AddComponent<PlayerView>();
            player.gameObject.SetActive(false);
            return player.gameObject;
        }
    }
}