using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "SO/Enemy", order = 0)]
    public class EnemySO : ScriptableObject
    {
        public int hp;
        public Sprite sprite;
    }
} 