using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] float shotInterval;
    [SerializeField] GameObject bullet;

    private float _timer;
    private ObjectPool _bulletPool;
    public void Init(ObjectPool pool)
    {
        _bulletPool = pool;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
