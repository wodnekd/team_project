using UnityEngine;
using System.Collections;

public class Character_Hp : MonoBehaviour {
	public static int nHP;
	public GameObject oCharacter;

	// Use this for initialization
	void Start () {
		nHP = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (nHP <= 0) {
			nHP=3;
			//oCharacter.transform.localPosition=new Vector3(0.09f,-0.16f,28.4f);
			Application.LoadLevel("Start");		
		}
		if (nHP > 5)
			nHP = 5;
	
	}
}
