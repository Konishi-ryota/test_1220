using UnityEngine;
public class PlayerShot : MonoBehaviour
{
    [SerializeField] float shotInterval;
    [SerializeField] GameObject muzzle;

    private float _timer;
    private ObjectPool _bulletPool;
    private Bullet _bullet;
    public void Init(ObjectPool pool)
    {
        _bulletPool = pool;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _timer < Time.time)
        {
            Shot();
            _timer = Time.time + shotInterval;
        }
    }
    
    private void Shot()
    {
        _bullet = _bulletPool.GetPooledObject();
        _bullet.transform.position = muzzle.transform.position;
        _bullet.transform .rotation = muzzle.transform.rotation;
    }
}
