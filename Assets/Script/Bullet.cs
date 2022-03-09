using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    private Rigidbody bulletRd = null;
    public float bulletSpd = 8f;

	private void OnTriggerEnter(Collider other)
	{//충돌 메세지를 발생하는것은 리지드바디임으로
     //충돌 판정을 하기 위해선 최소 하나는 리지드바디 가지고 있어야함.      

        //또한 두 게임 오브젝트 콜리더 중 최소 하나가 트리거 콜라이더면 호출됨
        //-> 양쪽 모두에서 일어남.
        //On Trigger ~ 함수로 실행됨. 또한 그대로 통과.
        //또한 Collider형을 받아오는데, 여기서는 상세한 충돌 정보 없음.

        //OnCollision은 일반 충돌 시 발생
        //또한 인자로 Collision형을 받아오는데, 여기서는 상세한 충돌 정보 유

        if (other.tag == "Player")
        {
            PlayerController playerCnt = other.GetComponent<PlayerController>();

            if (playerCnt != null)
            {
                playerCnt.PlayerDie();
            }
        }


		
	}


	// Start is called before the first frame update
	void Start()
    {
        if (bulletRd == null)
        {
            bulletRd = GetComponent<Rigidbody>();
        }
        bulletRd.velocity = transform.forward * bulletSpd;

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
