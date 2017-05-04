/*
	Author:			Khandker Faim Hussain
	Date:			Wed, 03/05/2017
	Description:	This script is used for giving the player 2D physics for movement. 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//VELOCITY UITILITY CLASS - 
public class VelocityRange
{
	//PUBLIC INSTANCE VARIABLES
	public float vMin, vMax;

	//CONSTRUCTOR
	public VelocityRange(float vMin, float vMax)
	{
		this.vMin = vMin;
		this.vMax = vMax;
	}
}

public class PlayerMovement : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES	
	public float speed = 50f; //setting the horizontal floating point 
	public float jump = 500f; //setting the vertical floating point 

	//Instance of "VelocityRange" to set up the limitation of float values. (IE. min = 300f and max = 1000f)
	public VelocityRange vRange = new VelocityRange(300f, 1000f);

	//PRIVATE INSTANCE VARIABLES
	private Rigidbody2D _rb2d; 
	private Transform _transform; 

	private float _movingValue = 0f; 
	private bool _isFacingRight = true;
	private bool _isGrounded = true;

//	private Animator _anim; //animator reference
//	private AudioSource[] _audioSources; //array
//	private AudioSource _playerDmgSound;

	// Use this for initialization
	void Start () 
	{
		//GameObject(s) references
		this._rb2d = gameObject.GetComponent<Rigidbody2D>();
		this._transform = gameObject.GetComponent<Transform>();
//		this._anim = gameObject.GetComponent<Animator>();
	}
	
	// Physics Update
	void FixedUpdate () 
	{
		//Represents the "Moving Force" for "Player"
		float forceX = 0f;
		float forceY = 0f;

		//NOTE: "Mathf.Abs" - Math function absolute value of whatever value/object within its parameters
		float absVelX = Mathf.Abs(this._rb2d.velocity.x);
		float absVelY = Mathf.Abs(this._rb2d.velocity.y);

		//Setting the player's horizontal movement. 
		//NOTE: For more info, check "InputManager" for all keys related to "Horizontal"
		this._movingValue = Input.GetAxis ("Horizontal");

		//Checks to see if player has changed _movingValue
		if (_movingValue != 0) {
			//Checks to see if player is grounded
			if (this._isGrounded) {
				//Setting the animation state
				//this._anim.SetInteger("AnimState", 1);

				//Checks to see if player is moving right (increasing _movingValue)
				if (this._movingValue > 0) {
					//IDK
					if (absVelX > this.vRange.vMax) {
						forceX = this.speed;
						this._isFacingRight = true;
//						this.flip ();
					}
				}
				//Checks to see if player is moving left (decresing _movingValue)
				if (this._movingValue < 0) {
					//IDK
					if (absVelX < this.vRange.vMax) {
						forceX = this.speed;
						this._isFacingRight = false;
						//this.flip();
					}
				}
			}
		}
		//Otherwise calls the "idle" animation
		else 
		{
			//this._anim.SetInteger("AnimStae", 0);
		}

		//Checks to see if player is jumping
		if(Input.GetKey("space")) //TRY LOWERCASE IF IT'S NOT WORKING
		{
			//Checks if player is grounded
			if(this._isGrounded)
			{
				//this._anim.SetInteger("AnimState", 2);
				if(absVelY < this.vRange.vMax)
				{
					forceY = this.jump;
					//this._jumpSound.Play();
					this._isGrounded = false;
				}
			}
		}
		//Adds a force to the player
		this._rb2d.AddForce(new Vector2(forceX, forceY));
	}

	//COLLISION METHODS
	//IDK
	void OnCollisionStay2D(Collision2D other)
	{
		//Checks if this object is "colliding" with another object's collider (IE. "Platform")
		if(other.gameObject.CompareTag("Platform"))
		{
			this._isGrounded = true;
		}
	}

//	//Collecting items
//	void OnCollisionEnter2D(Collision2D other)
//	{
//		//player hits coin then play "_elfSound"
//		if(other.gameObject.CompareTag("Coin"))
//		{
//			this._coinSound.Play ();
//		}
//	}

	//PRIVATE METHODS
	private void _Flip()
	{
		if (this._isFacingRight) 
		{
			//resets the scale of the sprite, "Player"
			this._transform.localScale = new Vector3 (1f, 1f, 1f);
		}
		//If not facing right, but instead left
		else
		{
			//resets the scale of the sprite, "Player"
			this._transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
}