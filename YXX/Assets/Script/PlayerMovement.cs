using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float movePower = 1f;
	public float jumpPower = 1f;

	public Camera mainCamera;

	Rigidbody2D rigid;
	Animator animator;

	public GameObject player;


	Vector3 movement;
	bool isJumping = false;
	bool isJumpIdle=false;

	int jumpCount = 1;

	float keyTime;

	public bool bJump=false;


	public GameObject[] hidden=new GameObject[10];
	public GameObject[] notHidden= new GameObject[10];

	int playerLayer, tileLayer;

	BoxCollider2D PlayerBox;

	public GameObject ob1;


	private bool chackSpaceOneMore = false;


	void Start()
	{
		rigid = gameObject.GetComponent<Rigidbody2D>();
		animator = player.GetComponent<Animator>();
		playerLayer = LayerMask.NameToLayer("player");
		tileLayer = LayerMask.NameToLayer("tile");
		PlayerBox = gameObject.GetComponent<BoxCollider2D>();


	}

	void Update()
	{



		
		if (gameObject.transform.position.y >= -5 && gameObject.transform.position.y < 5)
			mainCamera.transform.position = new Vector3(0, 0, -10);

		else if (gameObject.transform.position.y >= 5 && gameObject.transform.position.y < 15)
			mainCamera.transform.position = new Vector3(0, 10, -10);

		else if (gameObject.transform.position.y >= 15 && gameObject.transform.position.y < 25)
			mainCamera.transform.position = new Vector3(0, 20, -10);

		else if (gameObject.transform.position.y >= 25 && gameObject.transform.position.y < 35)
			mainCamera.transform.position = new Vector3(0, 30, -10);
		else if (gameObject.transform.position.y >= 35 && gameObject.transform.position.y < 45)
			mainCamera.transform.position = new Vector3(0, 40, -10);
		else if (gameObject.transform.position.y >= 45 && gameObject.transform.position.y < 55)
			mainCamera.transform.position = new Vector3(0, 50, -10);



		if(gameObject.transform.position.y>35)
        {
			PlayerBox.offset = new Vector3(0.2f,0f,0f);
			PlayerBox.size = new Vector3(0.4f, 2.6f, 0f);

		}
        else
        {
			PlayerBox.offset = new Vector3(0.2f,-1.3f,0f);
			PlayerBox.size = new Vector3(0.8f, 0.1f, 0f);
        }


		if (!isJumpIdle)
			Move();

		if (bJump == false)
		{

			if (Input.GetButtonDown("Jump"))
			{

				isJumpIdle = true;
				keyTime = 0;
				jumpPower = 1;
				ob1.SetActive(true);
				JumpBar.bjum = true;
				chackSpaceOneMore = true;
			}


			else if (Input.GetButton("Jump"))
			{
				if (chackSpaceOneMore == true)
					animator.SetBool("isJump", true);



			}
			else if (Input.GetButtonUp("Jump"))
			{
				if (chackSpaceOneMore == true)
				{

					isJumpIdle = false;
					isJumping = true;
					ob1.SetActive(false);

					chackSpaceOneMore = false;
				}

			}
			if (isJumpIdle == true)
			{
				keyTime += Time.deltaTime;


			}
		}

	}

	void FixedUpdate()
	{
		
		Jump();
	}


	void Move()
	{
		Vector3 moveVelocity = Vector3.zero;

		if (Input.GetAxisRaw("Horizontal") == 0)
		{
			animator.SetBool("isMoving", false);
		
		}


		else if (Input.GetAxisRaw("Horizontal") < 0&&gameObject.transform.position.x>-8)
		{
			moveVelocity = Vector3.left;
			animator.SetInteger("Direction", -1);
			animator.SetBool("isMoving", true);

			transform.localScale = new Vector3(-1, 1, 1);
		}

		else if (Input.GetAxisRaw("Horizontal") > 0 && gameObject.transform.position.x < 8)
		{
			moveVelocity = Vector3.right;
			animator.SetInteger("Direction", 1);
			animator.SetBool("isMoving", true);

			transform.localScale = new Vector3(1, 1, 1);
		}

		transform.position += moveVelocity * movePower * Time.deltaTime;
	}

	void Jump()
	{
		if (!isJumping)
		{
			animator.SetBool("isJump", false);
			return;
		}

		for (int i=0; i<10; ++i)
        {
			hidden[i].SetActive(true);
			notHidden[i].SetActive(false);

		}


		bJump = true;
		rigid.velocity = Vector2.zero;
		jumpPower *= keyTime*8;
		if (jumpPower > 10)
			jumpPower = 10;


		Vector2 jumpVelocity = new Vector2(0, jumpPower);
		rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

		isJumping = false;
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

		bJump = false;

		for (int i = 0; i < 10; ++i)
		{
			hidden[i].SetActive(false);
			notHidden[i].SetActive(true);

		}
	}



}
