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
		//RigidBody�� AddForce�� Velocity ����
		//AddForce�� ���� ������
		//Velocity�� ������ �ƴ϶� ���ο� �ӷ°� ����ϴ°�

		#region IfMove
		//if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		//{
		//    //������ �ٵ� �̿��ؼ� �̵��ϸ� �߷�, �浹 ���� ����.
		//    //Trasnform�� ���� �̵��ҽ� ���� x
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
