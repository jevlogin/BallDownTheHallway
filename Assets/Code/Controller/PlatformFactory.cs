using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal class PlatformFactory
    {
        #region Fields

        private readonly PlatformData _platformData;

        #endregion


        #region ClassLifeCycles

        public PlatformFactory(PlatformData platformData)
        {
            _platformData = platformData;
        }

        #endregion


        #region Methods

        internal PlatformView CreatePlatform()
        {
            return Object.Instantiate(_platformData.PlatformPrefab).GetComponent<PlatformView>();
        }

        #endregion
    }
}