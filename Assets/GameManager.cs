using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ObjectPool bulletPool;
    [SerializeField] PlayerShot playerShot;
    [SerializeField] Enemy enemy;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] Bullet bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerShot.ShotInit(bulletPool);
    }

}
