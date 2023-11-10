using UnityEngine;

namespace Ball
{
    public class BallScript : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private Rigidbody2D _rigidbody2D;

        private Vector2 _lastDirection;

        private void Awake()
        {
            SetDirection(Vector2.one);
        }

        public void Init()
        {

        }

        public void SetDirection(Vector2 direction)
        {
            _lastDirection = direction.normalized;
            _rigidbody2D.velocity = _lastDirection * _moveSpeed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var reflectedDirection = Vector2.Reflect(_lastDirection, collision.GetContact(0).normal);
            SetDirection(reflectedDirection);
        }
    }
}