using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public float jumpspeed;
    public CharacterController controller;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * movespeed, 0f, Input.GetAxis("Vertical") * movespeed);
        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpspeed;
        }
        moveDirection.y = moveDirection.y + Physics.gravity.y * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
