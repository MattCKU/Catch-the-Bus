using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]
    private float stunTime=0;
    [SerializeField]
    float moveSpeed = 3f;
    public Joystick joystick;
    Vector3 forward, right;

    private bool canMove;
    private float canMoveTime;
    
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        canMove=true;

	}

	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey && canMove){
            Move();
        }
        if(!canMove){
            if(Time.time >= canMoveTime){
                canMove=true;
            }
        }
        if(transform.position.y<=1.2){
            transform.position.Set(transform.position.x,1.2f,transform.position.z);
        }
	}

    void Move()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * joystick.Horizontal;
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * joystick.Vertical;

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        //transform.position += rightMovement;
        //transform.position += upMovement;
        rb.MovePosition(transform.position+rightMovement+upMovement);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Enemy"){
            Debug.Log("Player Hit");
            canMove=false;
            canMoveTime=Time.time+stunTime;
        }
    }

    public float getMovementSpeed()
    {
        return moveSpeed;
    }

    public void setMovementSpeed(float playerSpeed)
    {
       moveSpeed = playerSpeed;
    }
}
