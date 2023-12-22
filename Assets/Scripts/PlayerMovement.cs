using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 2f;
    private float horizontal;
    private float vertical;
    public Animator animator;
    public GameObject player;

    public SceneData sceneData;

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        player.transform.position = new Vector3 (sceneData.posX , sceneData.posY, 0);
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Animate();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical).normalized * speed;
       
    }

    void Animate()
    {
        animator.SetFloat("Horizontal", rb.velocity.x);
        animator.SetFloat("Vertical", rb.velocity.y);
    }
}
