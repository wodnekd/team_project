using UnityEngine;
using System.Collections;

public class bulletcontrol : MonoBehaviour {
	/*public float speed = 10.0f;
	float moveZ;
	float StartZ;
	//int Count;
	// Use this for initialization
	void Start () {
		StartZ = transform.position.z;
		//Count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (ChangeMode.bFire_Bird == true) {
			if (Move_Character.Right == true) {
				moveZ = transform.position.z + (speed * Time.deltaTime);
				//moveY = transform.position.y + (speed * Time.deltaTime);
				transform.position = new Vector3 (transform.position.x, transform.position.y, moveZ);
				//transform.position = new Vector3 (transform.position.x, moveY, transform.position.z);
				if (transform.position.z > StartZ + 2.0f) {
					Destroy (gameObject);
					ChangeMode.bFire_Bird=false;
				}
			} else if (Move_Character.Left == true) {
				moveZ = transform.position.z - (speed * Time.deltaTime);
				//moveY = transform.position.y + (speed * Time.deltaTime);
				transform.position = new Vector3 (transform.position.x, transform.position.y, moveZ);
				//transform.position = new Vector3 (transform.position.x, moveY, transform.position.z);
				if (transform.position.z < StartZ - 2.0f) {
					Destroy (gameObject);
					ChangeMode.bFire_Bird=false;
				}
			}
		} else {
			if (Move_Character.Right == true) {
				moveZ = transform.position.z + (speed * Time.deltaTime);
				//moveY = transform.position.y + (speed * Time.deltaTime);
				transform.position = new Vector3 (transform.position.x, transform.position.y, moveZ);
				//transform.position = new Vector3 (transform.position.x, moveY, transform.position.z);
				if (transform.position.z > StartZ + 2.0f) {
					Destroy (gameObject);
				}
			} else if (Move_Character.Left == true) {
				moveZ = transform.position.z - (speed * Time.deltaTime);
				//moveY = transform.position.y + (speed * Time.deltaTime);
				transform.position = new Vector3 (transform.position.x, transform.position.y, moveZ);
				//transform.position = new Vector3 (transform.position.x, moveY, transform.position.z);
				if (transform.position.z < StartZ - 2.0f) {
					Destroy (gameObject);
				}
			}
		}
	}*/

	public float speed = 10.0f;
	float moveZ;
	float StartZ;
	float Destroy_Distance;
	bool Left;
	//int Count;
	// Use this for initialization
	void Start () {
		StartZ = transform.position.z;
		Destroy_Distance = 3.0f;
		Left = false;
		if (Move_Character.Left == true) {
			speed = speed * (-1.0f);
			Destroy_Distance = Destroy_Distance * (-1.0f);
			Left=true;
		} 
		//Count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		moveZ = transform.position.z + (speed * Time.deltaTime);
		//moveY = transform.position.y + (speed * Time.deltaTime);
		transform.position = new Vector3 (transform.position.x, transform.position.y, moveZ);
		//transform.position = new Vector3 (transform.position.x, moveY, transform.position.z);
		if (Left == true) {
			if (transform.position.z < StartZ + Destroy_Distance) {
				Destroy (gameObject);
			}
		} else {
			if (transform.position.z > StartZ + Destroy_Distance) {
				Destroy (gameObject);
			}
		}
	}
	
	void OnDestroy()
	{
		speed = 10.0f;
		Destroy_Distance = 3.0f;
		Left = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Oni(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
		if (other.gameObject.name == "Bear(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
		if (other.gameObject.name == "Mouse(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
		if (other.gameObject.name == "Bat(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
		if (other.gameObject.name == "Snake(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
		if (other.gameObject.name == "Tree(Clone)") {
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (other.gameObject);		
		}
	}
}
