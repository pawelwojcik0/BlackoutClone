using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxPositionX;
    [SerializeField] private float movementSpeed;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        
        if (directionX > 0 && transform.position.x < maxPositionX || directionX < 0 && transform.position.x > - maxPositionX)
        {
            transform.position += Vector3.right * movementSpeed * directionX *Time.deltaTime;
        }
    }
}
