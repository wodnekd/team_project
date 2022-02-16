using UnityEngine;
using System.Collections;

public class Mouse_Move : MonoBehaviour {
	public GameObject Mouse_Num;
	float moveZ;
	float speed;
	float cnt;
	float Change_Time=0.1f;
	
	// Use this for initialization
	void Start () {
		speed = -0.8f;
		cnt = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		moveZ = Mouse_Num.transform.position.z + (speed * Time.deltaTime);
		
		cnt -= Time.deltaTime; 
		if (cnt < 0.0f) {
			cnt = 0.0f; 
		}
		
		if (Mouse_Num.name == "Mouse1(Clone)") {
			if (Mouse_Num.transform.localPosition.z > -12.937 || Mouse_Num.transform.localPosition.z < -13.408) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		} 
		else if (Mouse_Num.name == "Mouse2(Clone)") {
			if (Mouse_Num.transform.localPosition.z > -1.52 || Mouse_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Mouse_Num.name == "Mouse3(Clone)") {
			if (Mouse_Num.transform.localPosition.z > -1.52 || Mouse_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Mouse_Num.name == "Mouse4(Clone)") {
			if (Mouse_Num.transform.localPosition.z > -1.52 || Mouse_Num.transform.localPosition.z < -2.744) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Mouse_Num.name == "Mouse5(Clone)") {
			if (Mouse_Num.transform.localPosition.z > 5.044 || Mouse_Num.transform.localPosition.z < 4.009) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		else if (Mouse_Num.name == "Mouse6(Clone)") {
			if (Mouse_Num.transform.localPosition.z > 5.044 || Mouse_Num.transform.localPosition.z < 4.009) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Mouse_Num.name == "Mouse7(Clone)") {
			if (Mouse_Num.transform.localPosition.z > 5.044 || Mouse_Num.transform.localPosition.z < 4.009) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}

		else if (Mouse_Num.name == "Mouse8(Clone)") {
			if (Mouse_Num.transform.localPosition.z > 5.044 || Mouse_Num.transform.localPosition.z < 4.009) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
				} 
			}
		}
		
		Mouse_Num.transform.position = new Vector3 (Mouse_Num.transform.position.x, Mouse_Num.transform.position.y, moveZ);
		
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
