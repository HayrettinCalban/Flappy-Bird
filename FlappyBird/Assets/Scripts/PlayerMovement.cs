using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private GameObject deathscren;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource pointSFX;

    private void Start()
    {
        deathscren.SetActive(false);
        Time.timeScale = 1f;
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = Vector2.up * jumpSpeed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Score")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            pointSFX.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Pipes")
        {
            Time.timeScale = 0f;
            deathscren.SetActive(true);
            dieSFX.Play();
        }
    }
}
