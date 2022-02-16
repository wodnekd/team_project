using UnityEngine;
using System.Collections;

public class Tree_Move : MonoBehaviour {
	public GameObject Tree_Num;
	float moveZ;
	float speed;
	float cnt;
	float Change_Time=2.0f;
	Animator Tree_Ani;
	
	
	// Use this for initialization
	void Start () {
		speed = -0.15f;
		cnt = 0.0f;
		Tree_Ani=GetComponent <Animator> ();;
	}
	
	// Update is called once per frame
	void Update () {
		if(Tree_Num.name == "Tree5(Clone)")
			moveZ = Tree_Num.transform.position.z - (speed * Time.deltaTime);
		else
			moveZ = Tree_Num.transform.position.z + (speed * Time.deltaTime);
		
		cnt -= Time.deltaTime; 
		if (cnt < 0.0f) {
			cnt = 0.0f; 
			Tree_Ani.Play ("Stop");
		}
		
		if (Tree_Num.name == "Tree1(Clone)") {
			if (Tree_Num.transform.localPosition.z > -7.759 || Tree_Num.transform.localPosition.z < -8.806) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
					Tree_Ani.Play ("Take 001");
				} 
			}
		} 
		else if (Tree_Num.name == "Tree2(Clone)") {
			if (Tree_Num.transform.localPosition.z > -3.72 || Tree_Num.transform.localPosition.z < -4.617) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
					Tree_Ani.Play ("Take 001");
				} 
			}
		}
		
		else if (Tree_Num.name == "Tree3(Clone)") {
			if (Tree_Num.transform.localPosition.z > 2.89 || Tree_Num.transform.localPosition.z < 0.091) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
					Tree_Ani.Play ("Take 001");
				} 
			}
		}
		
		else if (Tree_Num.name == "Tree4(Clone)") {
			if (Tree_Num.transform.localPosition.z > 2.89 || Tree_Num.transform.localPosition.z < 0.091) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
					Tree_Ani.Play ("Take 001");
				} 
			}
		}
		
		else if (Tree_Num.name == "Tree5(Clone)") {
			if (Tree_Num.transform.localPosition.z > 10.636 || Tree_Num.transform.localPosition.z < 10.13) {
				if (cnt == 0.0) { 
					speed = speed * -1.0f;
					transform.Rotate (Vector3.up * -180.0f, Space.World);
					cnt = Change_Time; 
					Tree_Ani.Play ("Take 001");
				} 
			}
		}

		Tree_Num.transform.position = new Vector3 (Tree_Num.transform.position.x, Tree_Num.transform.position.y, moveZ);
		
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
