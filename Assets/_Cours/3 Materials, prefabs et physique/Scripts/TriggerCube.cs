using UnityEngine;

namespace Session3
{
    public class TriggerCube : MonoBehaviour
    {
        MeshRenderer _renderer;

        void Start()
        {
            _renderer = GetComponent<MeshRenderer>();
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("OnTriggerEnter");

            if (other.gameObject.CompareTag("Ball"))
            {
                Debug.Log("OnTriggerEnter with Ball");

                _renderer.material.color = Color.magenta;

                CollisionBall ball = other.gameObject.GetComponent<CollisionBall>();
                ball.CollideWithCube();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("OnTriggerStay");
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("OnTriggerExit");
        }
    }
}
