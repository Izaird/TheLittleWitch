using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
		[Header("Movement")]
		public float movementSpeed;


 	 	private Vector2 movement;
		Rigidbody2D playerRb;
		public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
			playerRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
			PlayerInput();
			animator.SetFloat("Horizontal", movement.x);
			animator.SetFloat("Vertical", movement.y);
			animator.SetFloat("Speed", movement.sqrMagnitude);

      
    } 

		private void FixedUpdate(){
			MovePlayer();

		}

		private void PlayerInput(){
			movement.x =  Input.GetAxisRaw("Horizontal");
	 	 	movement.y = Input.GetAxisRaw("Vertical");
		}

		private void MovePlayer(){
			playerRb.MovePosition(playerRb.position + movement * movementSpeed * Time.deltaTime);
		}
}
