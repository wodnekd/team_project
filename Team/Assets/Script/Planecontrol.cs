using UnityEngine;
using System.Collections;

public class Planecontrol : MonoBehaviour {
		public float speed = 10.0f;
		public GameObject shootPoint;
		public GameObject bullet;
	public GameObject Fire_Bird_Bullet;
	public GameObject BlueDragon_Bullet;
	Animator anim;
		// Use this for initialization
		void Start () {
		anim = GetComponent <Animator>();
		}
		
		// Update is called once per frame
		void Update () {
			
	//	if (Input.GetButtonDown ("Fire1")) 
	//		{
	//			FireBullet();
	//		}
	}
		public void FireBullet()
		{
			anim.Play ("Drow");
		if (ChangeMode.bFire_Bird == true) {
			Instantiate (Fire_Bird_Bullet, shootPoint.transform.position + new Vector3 (0.09f, 0.25f, 0.4f), Quaternion.Euler (0, 90, 0));
		} else if (ChangeMode.bBlueDragon == true) {
			Instantiate (BlueDragon_Bullet, shootPoint.transform.position + new Vector3 (0.09f, 0.15f, 0.1f), Quaternion.Euler (0, 90, 0));
		}
		else
			Instantiate (bullet, shootPoint.transform.position+new Vector3(0,0.15f,0.1f), Quaternion.identity);
		}
	}
