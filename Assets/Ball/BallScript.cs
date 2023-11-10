using UnityEngine;

namespace Ball
{
    public class BallScript : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private float _strength;

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
            // reflect of surface
            var reflectedDirection = Vector2.Reflect(_lastDirection, collision.GetContact(0).normal);
            SetDirection(reflectedDirection);

            // set damage to collided objects
            if (collision.gameObject.TryGetComponent<IDamagable>(out var component))
            {
                component.TakeDamage(_strength);
            }
        }
    }
}