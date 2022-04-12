using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    public static class Extentions
    {
        #region GameObject

        public static GameObject AddSphereCollider(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<SphereCollider>();
            return gameObject;
        }

        public static GameObject AddRigidbody(this GameObject gameObject)
        {
            gameObject.GetOrAddComponent<Rigidbody>();
            return gameObject;
        }

        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }
            return result;
        }

        #endregion
    }
}
