using UnityEngine;

namespace Player
{
    public sealed class PlayerInitializer : MonoBehaviour
    {
        [SerializeField] private LayerMask _cubeLayerMask;

        public PlayerRaycastCreator RaycastCreator { get; private set; }

        private void Awake()
        {
            RaycastCreator = new PlayerRaycastCreator(Camera.main, _cubeLayerMask);
        }
    }
}