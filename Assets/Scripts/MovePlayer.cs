using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] PlayerManager playermanager;
    [SerializeField] float moveSpeed;
    [SerializeField] float controllSpeed;

    //Touch settings
    [SerializeField] bool isTouching;
    float touchPosX;
    Vector3 direction;

    private void Start()
    {
        
    }

    private void Update()
    {
        getInput();
    }
    private void FixedUpdate()
    {
        if (playermanager.playerState == PlayerManager.PlayerState.Move)
        {
            transform.position += Vector3.forward * moveSpeed * Time.fixedDeltaTime;
        }
        if(isTouching)
        {
            touchPosX += Input.GetAxis("Mouse X") * controllSpeed * Time.fixedDeltaTime;
        }
        transform.position = new Vector3(touchPosX, transform.position.y, transform.position.z);
    }
    void getInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
}
