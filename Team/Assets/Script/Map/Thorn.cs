using UnityEngine;
using System.Collections;

public class Thorn : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider cLope)
	{
		if (cLope.gameObject.name == "가시") {
			Character_Hp.nHP=0;
		}
	}
}
