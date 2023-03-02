using UnityEngine;

namespace ColorManRun.ColorFeatures
{
    public class ColorBubble : MonoBehaviour
    {
        [SerializeField] private ParticleSpawner _particles;
        [SerializeField] private GameColor _color;
        [SerializeField] private Material _material;

        public GameColor Color => _color;
        public Material Material => _material;

        public bool CompareColor(GameColor color) => _color.Equals(color);

        public void Burst()
        {
            _particles.SpawnAndPlay();
            Destroy(gameObject);
        }
    }
}
