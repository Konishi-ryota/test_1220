using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.position = new Vector2(
           //à⁄ìÆîÕàÕÇêßå¿Ç∑ÇÈ
           Mathf.Clamp(transform.position.x + moveX, -8.5f, 8.5f),
           Mathf.Clamp(transform.position.y + moveY, -5f, 5f)
           );
    }
}
