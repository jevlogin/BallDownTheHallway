using System;

namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class InitializationController
    {
        private Data _data;

        public InitializationController(Data data)
        {
            _data = data;
        }

        internal ProfilePlayer GetProfilePlayer()
        {
            var playerFactory = new PlayerFactory(_data.PlayerData);
            var playerinitialization = new PlayerInitialization(playerFactory);

            return new ProfilePlayer(_data, playerinitialization.GetPlayerModel());
        }
    }
}