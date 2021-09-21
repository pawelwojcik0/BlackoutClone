using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    [SerializeField] private GameObject GameOverText;

    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.one * -ballSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOverText.SetActive(true);
    }
}
