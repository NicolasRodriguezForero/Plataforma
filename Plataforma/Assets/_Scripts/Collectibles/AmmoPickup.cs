using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;

        var shoot = collision.GetComponentInParent<PlayerShoot>();
        if (shoot != null)
        {
            shoot.RefillAmmo();
            Destroy(gameObject);
        }
    }
}
