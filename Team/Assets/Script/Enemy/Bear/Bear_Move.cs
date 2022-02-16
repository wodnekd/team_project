using UnityEngine;
using System.Collections;

public class Bear_Move : MonoBehaviour {
	Animator Bear_Ani;
	// Use this for initialization
	void Start () {
		Bear_Ani=GetComponent <Animator> ();;
	
	}
	
	// Update is called once per frame
	void Update () {
		Bear_Ani.Play ("Take 001");
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

		if (other.gameObject.name == "aaa") {
			Character_Hp.nHP=Character_Hp.nHP-1;
		}

		if (other.gameObject.name == "Blue_Dragon_pre(Clone)") {
			GameObject.Destroy(this.gameObject);
			Thuder.Thunder_Vector=other.transform.localPosition;
			GameObject.Destroy(other.gameObject);
			Thuder.Blue_Thuder=true;
		}
	}
}
