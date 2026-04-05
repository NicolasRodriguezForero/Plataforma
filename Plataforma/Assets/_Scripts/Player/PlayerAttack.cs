using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float bounceForce = 9f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && _rb.velocity.y < 0)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, bounceForce);
            collision.GetComponent<EnemyMovement>().canMove = false;
            Destroy(collision.gameObject, 0.1f);
        }
    }
}
