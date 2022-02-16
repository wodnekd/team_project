using UnityEngine;
using System.Collections;

public class Snake_Move : MonoBehaviour {
	public GameObject Snake_Num;
	float moveZ;
	float speed;
	float cnt;
	float Change_Time=0.1f;

	Animator Snake_Ani;
	
	// Use this for initialization
	void Start () {
		speed = -0.5f;
		cnt = 0.0f;
		Snake_Ani=GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Snake_Num.name == "Snake2(Clone)")
			moveZ = Snake_Num.transform.position.z - (speed * Time.deltaTime);
		else
			moveZ = Snake_Num.transform.position.z + (speed * Time.deltaTime);
		
		cnt -= Time.deltaTime; 

		if (cnt < 0.0f) {
			cnt = 0.0f; 
		}
		
		if (Snake_Num.name == "Snake1(Clone)") {
			if (Snake_Num.transform.localPosition.z > -11.404 || Snake_Num.transform.localPosition.z < -12.65) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		} 
		else if (Snake_Num.name == "Snake2(Clone)") {
			if (Snake_Num.transform.localPosition.z > -11.404 || Snake_Num.transform.localPosition.z < -12.65) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Snake_Num.name == "Snake3(Clone)") {
			if (Snake_Num.transform.localPosition.z > -1.52 || Snake_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Snake_Num.name == "Snake4(Clone)") {
			if (Snake_Num.transform.localPosition.z > -1.52 || Snake_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
				
		Snake_Num.transform.position = new Vector3 (Snake_Num.transform.position.x, Snake_Num.transform.position.y, moveZ);

		Snake_Ani.Play ("Snake_Walk");
		
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "bullet(Clone)") {
			GameObject.Destroy(this.gameObject);
			GameObject.Destroy(other.gameObject);		
		}

		if (other.gameObject.name == "Fire_Bird_pre(Clone)") {
			GameObject.Destroy(this.gameObject);
		}

		if (other.gameObject.name == "Blue_Dragon_pre(Clone)") {
			GameObject.Destroy(this.gameObject);
			Thuder.Thunder_Vector=other.transform.localPosition;
			GameObject.Destroy(other.gameObject);
			Thuder.Blue_Thuder=true;
		}
		
		if (other.gameObject.name == "aaa") {
			Character_Hp.nHP=Character_Hp.nHP-1;
		}
	}
}
