using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet_1;
    public GameObject bullet_2;
    private GameObject selectedBullet;
    public Transform startPos;
    public int maxShotsPerGameBullet1 = 3;
    public int maxShotsPerGameBullet2 = 3;

    private int _shotsLeft1;
    private int _shotsLeft2;

    void Start()
    {
        _shotsLeft1 = maxShotsPerGameBullet1;
        _shotsLeft2 = maxShotsPerGameBullet2;
        selectedBullet = bullet_1;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (!context.started)
            return;

        if (selectedBullet == bullet_1)
        {
            if (_shotsLeft1 <= 0)
                return;
            _shotsLeft1--;
        }
        else if (selectedBullet == bullet_2)
        {
            if (_shotsLeft2 <= 0)
                return;
            _shotsLeft2--;
        }
        else
            return;
        GameObject bulletClone = Instantiate(selectedBullet, startPos.position, startPos.rotation);
        if (selectedBullet == bullet_1)
            Destroy(bulletClone, 1);
    }

    public void RefillAmmo()
    {
        _shotsLeft1 = maxShotsPerGameBullet1;
        _shotsLeft2 = maxShotsPerGameBullet2;
    }

    public void SelectBullet(InputAction.CallbackContext context)
    {
        if (!context.started)
            return;

        var path = context.control.path;
        if (path == "/Keyboard/1" || path == "<Keyboard>/1")
            selectedBullet = bullet_1;
        else if (path == "/Keyboard/2" || path == "<Keyboard>/2")
            selectedBullet = bullet_2;
    }
}