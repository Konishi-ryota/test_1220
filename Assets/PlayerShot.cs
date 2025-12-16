using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] float shotInterval;
    [SerializeField] GameObject bullet;

    private ObjectPool<Bullet> _bulletPool;
    private List<Bullet> _activeBullets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
