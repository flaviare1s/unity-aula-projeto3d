using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Transform myCamera;
    private Animator animator;
    public float speed = 2f;
    private bool isGround;
    private float yForce;
    [SerializeField] private Transform foot;
    [SerializeField] private LayerMask colisionLayer;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        myCamera = Camera.main.transform;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction = myCamera.TransformDirection(direction);
        direction.y = 0;

        controller.Move(direction * speed * Time.deltaTime);

        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * 10);
        }
        animator.SetBool("Move", direction != Vector3.zero);

        isGround = Physics.CheckSphere(foot.position, 0.3f, colisionLayer);
        animator.SetBool("isGround", isGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            yForce = 5f;
            animator.SetTrigger("Jump");
        }

        if (yForce > -9.81f)
        {
            yForce += -9.81f * Time.deltaTime;
        }

        controller.Move(new Vector3(0, yForce, 0) * Time.deltaTime);
    }
}
