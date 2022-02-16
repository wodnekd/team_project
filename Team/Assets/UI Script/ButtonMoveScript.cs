using UnityEngine;
using System.Collections;

public class ButtonMoveScript : MonoBehaviour {
	Animator anim;
	public static float speed=1.0f;

	bool bRight;
	bool bLeft;

	float Jump_Time; 
	float cnt; 
	float Jump_speed;
	


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		bRight = true;
		bLeft = false;

		Jump_speed = 0.0f;
		cnt = 0.0f;
		Jump_Time = 0.4f;
	}
	
	// Update is called once per frame
	void Update () {
		cnt -= Time.deltaTime; 
		if (cnt <0.0f){
			cnt = 0.0f; 
		}
	}
	public void Jump()
	{
		//점프
		if(cnt == 0.0) 
		{ 
			Jump_speed=0.5f;
			cnt = Jump_Time; 
			anim.Play ("Jump");
		} 
	
		if (Jump_speed > 0.0f)
			Jump_speed -= 0.0015f;
		else
			Jump_speed = 0;
		
		transform.Translate (Vector3.up * Jump_speed, Space.World);

		//anim.Play ("Jump");
	
	}

	public void up(){
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
		
	}
	

	public void left(){
		anim.Play ("Walking");
		transform.Translate (Vector3.back * 2.0f*Time.deltaTime, Space.World);
		if(bLeft==false)
		{
			transform.Rotate (Vector3.up * -180.0f, Space.World);
			bLeft=true;
			bRight=false;
		}

		//anim.Play ("stop");
	
	}
	
	public void right(){
			//if (Input.GetMouseButtonDown (0)) {
		anim.Play ("Walking");
		transform.Translate (Vector3.forward * 2.0f*Time.deltaTime, Space.World);
		if(bRight==false)
		{
			transform.Rotate (Vector3.up * -180.0f, Space.World);
			bRight=true;
			bLeft=false;
		}
		//}
		//else {
		//	anim.Play ("stop");
		//}
	}
	
}
