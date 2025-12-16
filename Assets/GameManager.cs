using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] ObjectPool bulletPool;
    [SerializeField] PlayerShot playerShot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerShot.Init(bulletPool);
    }

}
