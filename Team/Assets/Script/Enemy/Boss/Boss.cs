using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
	Animator Boss_Ani;
	// Use this for initialization
	void Start () {
		Boss_Ani=GetComponent <Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Boss_Ani.Play ("Take 001");
	
	}
}
