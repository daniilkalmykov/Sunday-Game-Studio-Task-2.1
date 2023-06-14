using System.Linq;
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
            SetRandomMaterial();
        }

        public void SetRandomMaterial()
        {
            Shuffle();

            _meshRenderer.material =
                _materials.FirstOrDefault(material => material.color != _meshRenderer.material.color);
        }

        private void Shuffle()
        {
            for (var i = 0; i < _materials.Length; i++)
            {
                var tempMaterial = _materials[i];
                var randomNumber = Random.Range(i, _materials.Length);

                _materials[i] = _materials[randomNumber];
                _materials[randomNumber] = tempMaterial;
            }
        }
    }
}
