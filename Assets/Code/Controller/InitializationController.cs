using System;

namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class InitializationController
    {
        #region Fields
        
        private Data _data;
        private ProfilePlayer _playerProfile;

        #endregion

        public Data Data => _data;

        #region ClassLifeCycles

        public InitializationController(Data data)
        {
            _data = data;
        }

        #endregion


        #region Methods

        internal ProfilePlayer GetProfilePlayer()
        {
            if (_playerProfile == null)
            {
                var playerFactory = new PlayerFactory(_data.PlayerData);
                var playerinitialization = new PlayerInitialization(playerFactory);
                _playerProfile = new ProfilePlayer(_data, playerinitialization.GetPlayerModel());
            }

            return _playerProfile;
        }

        #endregion
    }
}