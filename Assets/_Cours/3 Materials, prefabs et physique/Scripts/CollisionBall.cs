using UnityEngine;

namespace Session3
{
    public class CollisionBall : MonoBehaviour
    {
        public void CollideWithCube()
        {
            Renderer ballRenderer = GetComponent<Renderer>();
            ballRenderer.material.color = new Color(0, 1, 0);
        }
    }
}
