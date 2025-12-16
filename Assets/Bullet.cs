using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;
    private ObjectPool pool;
    public ObjectPool Pool { get => pool; set => pool = value; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(bulletSpeed * Time.deltaTime, 0, 0);
    }
    public void Release()
    {
        pool.ReturnToPool(this);
    }
}
