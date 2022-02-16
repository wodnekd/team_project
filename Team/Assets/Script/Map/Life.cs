using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	public Collider cCharacter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider cCharacter)
	{
		if (cCharacter.gameObject.name == "aaa") {
			GameObject.Destroy (this.gameObject);
			Character_Hp.nHP = Character_Hp.nHP + 1;
		}
	}
}
