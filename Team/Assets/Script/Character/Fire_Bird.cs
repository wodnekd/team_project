using UnityEngine;
using System.Collections;

public class Fire_Bird : MonoBehaviour {
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
				ChangeMode.bFire_Bird = false;
			}
		} else {
			if (transform.position.z > StartZ + Destroy_Distance) {
				Destroy (gameObject);
				ChangeMode.bFire_Bird = false;
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
	}
}
