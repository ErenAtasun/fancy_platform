using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Animator anim;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 5f;

    private bool grounded;
    private bool gameStarted;


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gameStarted = true;
    }

    private void Update()
    {
        if(Input.GetKey("space"))
        {
            Debug.Log("Jumping");
        }
    }

}
