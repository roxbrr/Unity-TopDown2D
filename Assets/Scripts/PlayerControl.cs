using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

  public int movementSpeed = 1;   //Movement Speed of vehicle
  public int rotateSpeed = 12;    //Rotate speed of vehicle

  public float verticalInput = 0;
  public float horizontalInput = 0;

  Rigidbody2D rigidBody2D;
  Transform turret;

  // public GameObject turret;


    // Start is called before the first frame update
    void Start()
    {
      rigidBody2D = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
      // TurretRotation();
    }

    void FixedUpdate()
    {
      verticalInput = Input.GetAxisRaw("Vertical");         //gets raw vertical input
      horizontalInput = Input.GetAxisRaw("Horizontal");     //gets raw horizontal input

      this.transform.Translate(0f, verticalInput * movementSpeed * Time.deltaTime, 0f);
      this.transform.Rotate(0f, 0f, -horizontalInput * (rotateSpeed * 10) * Time.deltaTime);
    }


    // void TurretRotation()
    // {
    //   Vector3 mousePosition = Input.mousePosition;
    //   mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    //
    //   Vector2 direction = new Vector2(mousePosition.x - turret.transform.position.x,  //
    //   mousePosition.y - turret.transform.position.y);
    //
    //   turret.transform.up = direction;
    // }

}
