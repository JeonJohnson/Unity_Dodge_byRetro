using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]
    private Rigidbody bulletRd = null;
    public float bulletSpd = 8f;

	private void OnTriggerEnter(Collider other)
	{//�浹 �޼����� �߻��ϴ°��� ������ٵ�������
     //�浹 ������ �ϱ� ���ؼ� �ּ� �ϳ��� ������ٵ� ������ �־����.      

        //���� �� ���� ������Ʈ �ݸ��� �� �ּ� �ϳ��� Ʈ���� �ݶ��̴��� ȣ���
        //-> ���� ��ο��� �Ͼ.
        //On Trigger ~ �Լ��� �����. ���� �״�� ���.
        //���� Collider���� �޾ƿ��µ�, ���⼭�� ���� �浹 ���� ����.

        //OnCollision�� �Ϲ� �浹 �� �߻�
        //���� ���ڷ� Collision���� �޾ƿ��µ�, ���⼭�� ���� �浹 ���� ��

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
