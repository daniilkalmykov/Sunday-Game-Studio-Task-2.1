using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerInitializer))]
    public sealed class PlayerInput : MonoBehaviour
    {
        private PlayerInitializer _playerInitializer;

        private void Awake()
        {
            _playerInitializer = GetComponent<PlayerInitializer>();
        }

        private void Update()
        {
            if (Input.touchCount != 1)
                return;

            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                    _playerInitializer.RaycastCreator.Create(touch.position);
            }
        }
    }
}