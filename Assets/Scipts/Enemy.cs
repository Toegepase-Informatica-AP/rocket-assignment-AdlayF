using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 5f;
  
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
         Vector3 direction = player.position - transform.position;
         direction.Normalize();
         movement = direction;
        transform.LookAt(player);
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.fixedDeltaTime));
    }
  
}
