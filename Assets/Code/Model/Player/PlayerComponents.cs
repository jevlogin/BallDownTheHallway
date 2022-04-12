using UnityEngine;


namespace WORLDGAMEDEVELOPMENT
{
    public sealed class PlayerComponents
    {
        [HideInInspector] public Collider ColliderPlayer;
        [HideInInspector] public Transform TransformPlayer;
        [HideInInspector] public Rigidbody RigidbodyPlayer;
    }
}
