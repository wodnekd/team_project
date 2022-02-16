using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
	public GameObject oGhost_1;
	public GameObject oGhost_2;
	public GameObject oGhost_3;
	public GameObject oGhost_4;
	public GameObject oGhost_5;
	public GameObject oGhost_6;

	//public GameObject Character;
	bool Live;
	
	Vector3 startPos;
	Vector3 startScale;
	// Use this for initialization
	void Start () {
		Live = false;
	}
	
	// Update is called once per frame
	void Update () {
			if(Live==false)
			{
				StartCoroutine(first_create(0.2f));
				StartCoroutine(second_create(0.2f));
				StartCoroutine(third_create(0.2f));
				StartCoroutine(forth_create(0.2f));
				StartCoroutine(fifth_create(0.2f));
				StartCoroutine(sixth_create(0.2f));
				Live=true;
			}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-0.099f,-14.32f);
		Instantiate (oGhost_1,startPos,Quaternion.Euler(-90,90,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-2.319f,-10.262f);
		Instantiate (oGhost_2,startPos,Quaternion.Euler(-90,90,0));
	}

	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-3.216f,-6.155f);
		Instantiate (oGhost_3,startPos,Quaternion.Euler(-90,90,0));
	}

	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,1.108f,11.95f);
		Instantiate (oGhost_4,startPos,Quaternion.Euler(-90,90,0));
	}
	
	IEnumerator fifth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.573f,15.087f);
		Instantiate (oGhost_5,startPos,Quaternion.Euler(-90,90,0));
	}
	
	IEnumerator sixth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.27f,10.778f);
		Instantiate (oGhost_6,startPos,Quaternion.Euler(-90,270,0));
	}
}
