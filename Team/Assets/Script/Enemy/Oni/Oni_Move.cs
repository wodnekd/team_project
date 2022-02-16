using UnityEngine;
using System.Collections;

public class Oni_Move : MonoBehaviour {
	public GameObject Oni_Num;
	float moveZ;
	float speed;
	float cnt;
	float Change_Time=0.1f;
	Animator Oni_Ani;
	
	// Use this for initialization
	void Start () {
		speed = -0.35f;
		cnt = 0.0f;
		Oni_Ani=GetComponent <Animator> ();;
	}
	
	// Update is called once per frame
	void Update () {
		if(Oni_Num.name == "Oni3(Clone)" || Oni_Num.name == "Oni6(Clone)")
			moveZ = Oni_Num.transform.position.z - (speed * Time.deltaTime);
		else
			moveZ = Oni_Num.transform.position.z + (speed * Time.deltaTime);
		
		cnt -= Time.deltaTime; 
		if (cnt < 0.0f) {
			cnt = 0.0f; 
		}
		
		if (Oni_Num.name == "Oni1(Clone)") {
			if (Oni_Num.transform.localPosition.z > -15.66921 || Oni_Num.transform.localPosition.z < -16.04) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		} 
		else if (Oni_Num.name == "Oni2(Clone)") {
			if (Oni_Num.transform.localPosition.z > -11.404 || Oni_Num.transform.localPosition.z < -12.65) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Oni_Num.name == "Oni3(Clone)") {
			if (Oni_Num.transform.localPosition.z > -11.404 || Oni_Num.transform.localPosition.z < -12.65) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Oni_Num.name == "Oni4(Clone)") {
			if (Oni_Num.transform.localPosition.z > -1.52 || Oni_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Oni_Num.name == "Oni5(Clone)") {
			if (Oni_Num.transform.localPosition.z > -1.52 || Oni_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Oni_Num.name == "Oni6(Clone)") {
			if (Oni_Num.transform.localPosition.z > 11.395 || Oni_Num.transform.localPosition.z < 10.316) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		Oni_Num.transform.position = new Vector3 (Oni_Num.transform.position.x, Oni_Num.transform.position.y, moveZ);

		Oni_Ani.Play ("Take 001");
		
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
