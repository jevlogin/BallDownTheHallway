using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    internal sealed class ParallaxManager
    {
        private readonly Camera _camera;

        public ParallaxManager(Camera camera)
        {
            _camera = camera;
        }
    }
}