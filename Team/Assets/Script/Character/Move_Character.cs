using UnityEngine;
using System.Collections;

public class Move_Character : MonoBehaviour {
	public static float speed=1.0f;
	public GameObject sammi;
	public static bool Left;
	public static bool Right;

	float Jump_Time; 
	float cnt; 
	float cnt2;
	float fTiger;
	float Jump_speed;

	float Lope_Speed;

	Animator anim;

	// Use this for initialization
	void Start () {
		Left = false;
		Right = true;
		anim = GetComponent <Animator> ();

		Jump_speed = 0.0f;
		cnt = 0.0f;
		Jump_Time = 0.4f;
		Lope_Speed=0.5f;
		anim.StopPlayback ();

		cnt2 = 0.0f;
		fTiger = 5.0f;
	}

	/*void OnTriggerEnter(Collider Lope)
	{
		transform.Rotate (Vector3.up * -90.0f, Space.World);
	}*/

	// Update is called once per frame
	void Update () {

		//좌우이동
		float key_Hor = Input.GetAxis ("Horizontal");
		
		float move_Hor = key_Hor * speed * Time.deltaTime;
		transform.Translate (Vector3.forward * move_Hor, Space.World);

		//좌우이동 애니메이션
		if(Input.GetKey (KeyCode.LeftArrow))
		{
				
			anim.Play ("Walking");
			
			if(Left==false)
			{
				transform.Rotate (Vector3.up * -180.0f, Space.World);
				Left=true;
				Right=false;
			}
		}


		if (Input.GetKey ("d") || Input.GetKey ("right") ) {
			anim.Play ("Walking");
			if(Right==false)
			{
				transform.Rotate (Vector3.up * -180.0f, Space.World);
				Right=true;
				Left=false;
			}
		}
		/*else if(Input.GetKeyUp ("d") || Input.GetKeyUp ("right") ) {
			anim.StopPlayback ();
		}*/


		//점프
		if(cnt == 0.0) 
		{ 
			if (Input.GetButtonDown ("Jump")) 
			{ 
				Jump_speed=0.05f;
				cnt = Jump_Time; 
				anim.Play ("Jump");
			} 
		} 
		else 
		{ 
			cnt -= Time.deltaTime; 
			if (cnt <0.0f){
				cnt = 0.0f; 
			}
		} 
		if (Jump_speed > 0.0f)
			Jump_speed -= 0.0015f;
		else
			Jump_speed = 0;

		transform.Translate (Vector3.up * Jump_speed, Space.World);


		if ( Lope.bLoop== true) {
            anim.Play("Up");
            float key_Ver = Input.GetAxis ("Vertical");

			float move_Ver = key_Ver * Lope_Speed * Time.deltaTime * 3.0f;
			transform.Translate (Vector3.up * move_Ver, Space.World);

		}

		if (sammi.transform.localPosition.y < -5.0f)
			Character_Hp.nHP = 0;


		if (ChangeMode.bTiger == true) {
			Physics.gravity = new Vector3 (0, 0.0f, 0);
			if(cnt2 == 0.0) 
			{ 
				cnt2 = fTiger;  
			} 
			else 
			{ 
				cnt2 -= Time.deltaTime; 
				if (cnt2 <0.0f){
					cnt2 = 0.0f; 
					ChangeMode.bTiger=false;
				}
			}

			float key_Ver = Input.GetAxis ("Vertical");
			
			float move_Ver = key_Ver * Lope_Speed * Time.deltaTime * 3.0f;
			transform.Translate (Vector3.up * move_Ver, Space.World);
		}
		else
			Physics.gravity=new Vector3(0,-4.9f,0);
	
	}


}
