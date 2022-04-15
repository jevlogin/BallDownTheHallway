using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class PlatformController : IInitialization
    {
        private PlatformFactory _platformFactory;

        public PlatformController(PlatformFactory platformFactory)
        {
            _platformFactory = platformFactory;
        }

        public void Initialization()
        {
            _platformFactory.CreatePlatform();
        }
    }
}
