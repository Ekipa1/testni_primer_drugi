using UnityEngine;
using System.Collections;

public class firstperson : MonoBehaviour {

    float movementSpeed = 5.0f;
    public float mouseSensitivity = 5.0f;
   // public float jumpSpeed = 20.0f;
    float verticalVelocity = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //rotation
        
       float rotleftright= Input.GetAxis("Mouse X") * mouseSensitivity;

        transform.Rotate(0, rotleftright, 0);

        float rotupdown = Input.GetAxis("Mouse Y") * mouseSensitivity;
        Camera.main.transform.Rotate(rotupdown,0,0);

        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
        Vector3 speed = new Vector3(sideSpeed, 100, forwardSpeed);

        speed = transform.rotation * speed;

        /*if(Input.GetButtonDown("Jump"))
        {
            verticalVelocity = jumpSpeed;
        }*/

        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);
	}
}
