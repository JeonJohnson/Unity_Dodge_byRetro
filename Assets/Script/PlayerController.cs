using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody playerRd;
    public float playerSpeed = 8f;


    void PlayerMove()
    {
		//RigidBody의 AddForce와 Velocity 차이
		//AddForce는 힘이 누적됨
		//Velocity는 누적이 아니라 새로운 속력값 사용하는거

		#region IfMove
		//if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		//{
		//    //리지드 바디를 이용해서 이동하면 중력, 충돌 영향 받음.
		//    //Trasnform을 직접 이동할시 영향 x
		//    playerRd.AddForce(new Vector3(0f, 0f, playerSpeed));
		//}
		//if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		//{
		//    playerRd.AddForce(new Vector3(0f, 0f, -playerSpeed));
		//}

		//if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		//{
		//    playerRd.AddForce(new Vector3(playerSpeed, 0f, 0f));
		//}
		//if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		//{
		//    playerRd.AddForce(new Vector3(-playerSpeed, 0f, 0f));
		//}
		#endregion

		#region VelocityMove
		float xInput = Input.GetAxis("Horizontal");
		float zInput = Input.GetAxis("Vertical");

		Vector3 newVelocity = new Vector3(xInput * playerSpeed, 0f, zInput * playerSpeed);
		playerRd.velocity = newVelocity;
		#endregion
	}

	public void PlayerDie()
    {
        gameObject.SetActive(false);

		GameMgr.instance.GameEnd();
    }

	private void Awake()
	{
        playerRd = this.GetComponent<Rigidbody>();
	}

	void Start()
    {
        
    }

    void Update()
    {
        PlayerMove();
        
    }
}
