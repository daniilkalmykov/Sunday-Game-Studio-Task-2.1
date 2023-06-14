using Cube;
using UnityEngine;

namespace Player
{
    public sealed class PlayerRaycastCreator
    {
        private readonly Camera _camera;
        private readonly LayerMask _layerMask;
        
        public PlayerRaycastCreator(Camera camera, LayerMask layerMask)
        {
            _camera = camera;
            _layerMask = layerMask;
        }
        
        public void Create(Vector3 position)
        {
            var ray = _camera.ScreenPointToRay(position);

            if (Physics.Raycast(ray, out var hit, _layerMask) == false)
                return;

            if (hit.transform.gameObject.TryGetComponent(out CubeMaterialSwitcher cubeMaterialSwitcher))
                cubeMaterialSwitcher.SetRandomMaterial();
        }
    }
}