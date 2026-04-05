using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPos;
    public int maxShotsPerGame = 3;

    private int _shotsLeft;

    void Start()
    {
        _shotsLeft = maxShotsPerGame;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (!context.started || _shotsLeft <= 0)
            return;

        _shotsLeft--;
        GameObject bulletClone = Instantiate(bullet, startPos.position, startPos.rotation);
        Destroy(bulletClone, 1);
    }

    public void RefillAmmo()
    {
        _shotsLeft = maxShotsPerGame;
    }
}