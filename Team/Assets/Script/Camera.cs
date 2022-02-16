using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public GameObject target;
	public Vector3 iniPos;
	public Vector3 nowPos;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position - new Vector3 (-12,-0.6f,-1.0f);
	}
}
