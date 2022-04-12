using System;


namespace WORLDGAMEDEVELOPMENT
{
    internal class PlayerInitialization
    {
        private readonly PlayerFactory _playerFactory;
        private PlayerModel _playerModel;

        public PlayerInitialization(PlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
            _playerModel = _playerFactory.CreatePlayerModel();
        }

        internal PlayerModel GetPlayerModel()
        {
            return _playerModel;
        }
    }
}