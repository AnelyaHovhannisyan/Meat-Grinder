using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float lastFrameFingerPositionX;
    private float moveFactorX;
    public float swerveAmount;
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField] private float swerveSpeed = 3;
    [SerializeField] private float maxSwerveAmount = 2.5f;

    void FixedUpdate()
    {
        Vector3 move = transform.forward * speed * Time.fixedDeltaTime+transform.right*swerveAmount;
        rb.MovePosition(rb.position + move);
    


    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveFactorX = Input.mousePosition.x - lastFrameFingerPositionX;
            lastFrameFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0f;
        }
        swerveAmount = Time.deltaTime * swerveSpeed * moveFactorX;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);
   
    }
}
