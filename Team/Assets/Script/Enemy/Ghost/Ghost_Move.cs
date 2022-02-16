using UnityEngine;
using System.Collections;

public class Ghost_Move : MonoBehaviour {
	public GameObject Ghost_Num;
	float moveZ;
	float speed;
	float cnt;
	float Change_Time=0.1f;

	// Use this for initialization
	void Start () {
		speed = -0.3f;
		cnt = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Ghost_Num.name == "Ghost6(Clone)")
			moveZ = Ghost_Num.transform.position.z - (speed * Time.deltaTime);
		else
			moveZ = Ghost_Num.transform.position.z + (speed * Time.deltaTime);

		cnt -= Time.deltaTime; 
		if (cnt < 0.0f) {
			cnt = 0.0f; 
		}

		if (Ghost_Num.name == "Ghost1(Clone)") {
			if (Ghost_Num.transform.localPosition.z > -13.203 || Ghost_Num.transform.localPosition.z < -14.758) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		} 
		else if (Ghost_Num.name == "Ghost2(Clone)") {
			if (Ghost_Num.transform.localPosition.z > -10.262 || Ghost_Num.transform.localPosition.z < -10.962) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Ghost_Num.name == "Ghost3(Clone)") {
			if (Ghost_Num.transform.localPosition.z > -6.155 || Ghost_Num.transform.localPosition.z < -6.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Ghost_Num.name == "Ghost4(Clone)") {
			if (Ghost_Num.transform.localPosition.z > 11.95 || Ghost_Num.transform.localPosition.z < 11.155) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Ghost_Num.name == "Ghost5(Clone)") {
			if (Ghost_Num.transform.localPosition.z > 15.087 || Ghost_Num.transform.localPosition.z < 14.735) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Ghost_Num.name == "Ghost6(Clone)") {
			if (Ghost_Num.transform.localPosition.z > 11.345 || Ghost_Num.transform.localPosition.z < 10.345) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		Ghost_Num.transform.position = new Vector3 (Ghost_Num.transform.position.x, Ghost_Num.transform.position.y, moveZ);
		
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
