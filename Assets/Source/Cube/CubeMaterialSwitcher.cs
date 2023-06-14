using UnityEngine;

namespace Cube
{
    [RequireComponent(typeof(MeshRenderer))]
    public sealed class CubeMaterialSwitcher : MonoBehaviour
    {
        [SerializeField] private Material[] _materials;

        private MeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        private void Start()
        {
            _meshRenderer.materials = _materials;
            
            SetRandomMaterial();
        }

        public void SetRandomMaterial()
        {
            var materials = _meshRenderer.materials;
            
            (materials[0], materials[1]) = (materials[1], materials[0]);
        }
    }
}
