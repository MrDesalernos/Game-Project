using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingController : MonoBehaviour
{
    public CharacterController controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("up"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump)

    }

}
