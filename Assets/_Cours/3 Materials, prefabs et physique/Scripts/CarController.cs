using UnityEngine;

namespace Session3
{
    public class CarController : MonoBehaviour
    {
        public float speed = 0.01f;
        public float rotationSpeed = 1;
        public bool useAddForce = true;
        public bool useVelocity = false;
        public bool useMovePosition = false;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            // transform.right correspond à l'axe X positif, et transform.up à Y positif
            Vector3 verticalForce = vertical * speed * Time.deltaTime * transform.right;
            Vector3 horizontalForce = horizontal * rotationSpeed * Time.deltaTime * transform.up;

            if (useAddForce)
            {
                _rigidbody.AddForce(verticalForce, ForceMode.Force);
            }
            else if (useVelocity)
            {
                _rigidbody.velocity = verticalForce / 20f;
            }
            else if (useMovePosition)
            {
                _rigidbody.MovePosition(_rigidbody.position + verticalForce / 1000f);
            }

            transform.Rotate(horizontalForce * _rigidbody.velocity.magnitude, Space.Self);
        }
    }
}
