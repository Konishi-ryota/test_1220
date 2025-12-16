using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float enemyHitBox;

    private Bullet _bullet;
    private PlayerMove _playerMove;
    private float distance;

    public void EnemyInit(PlayerMove player , Bullet bullet)
    {
        _playerMove = player;
        _bullet = bullet;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerHit();
    }
    private void CheckPlayerHit()
    {
        if (_playerMove == null)
        {
            Debug.LogError("PlayerMove is Null");
            return;
        }
        distance = Vector2.Distance(transform.position, transform.position);
        if (distance > enemyHitBox + _playerMove.PlayerHitBox)
        {
            _playerMove.OnEnemyHit();
            Destroy(this);
        }
    }
}
