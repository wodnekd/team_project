using UnityEngine;
using System.Collections;

public class Boss_Stage : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "큰혼불(보스전)")
			Application.LoadLevel ("Boss");
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
