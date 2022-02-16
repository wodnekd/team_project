using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
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
			ScoreManager.score = ScoreManager.score + 1;
		}
		
	}
	
}
