using UnityEngine;

namespace Session3
{
    public class CollisionCube : MonoBehaviour
    {
        MeshRenderer _renderer;

        void Start()
        {
            _renderer = GetComponent<MeshRenderer>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("OnCollisionEnter");

            if (collision.gameObject.CompareTag("Ball"))
            {
                Debug.Log("OnCollisionEnter with Ball");

                _renderer.material.color = Color.magenta;

                CollisionBall ball = collision.gameObject.GetComponent<CollisionBall>();
                ball.CollideWithCube();
            }
        }
    }
}
