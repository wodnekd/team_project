using UnityEngine;
using System.Collections;

public class Oni : MonoBehaviour {
	public GameObject oOni_1;
	public GameObject oOni_2;
	public GameObject oOni_3;
	public GameObject oOni_4;
	public GameObject oOni_5;
	public GameObject oOni_6;
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

		if (Live == true) {
		}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-4.183021f,-15.66921f);
		Instantiate (oOni_1,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-4.022107f,-11.517f);
		Instantiate (oOni_2,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-4.022107f,-12.65f);
		Instantiate (oOni_3,startPos,Quaternion.Euler(0,0,0));
	}

	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.582f,-1.876f);
		Instantiate (oOni_4,startPos,Quaternion.Euler(0,180,0));
	}
	
	IEnumerator fifth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.582f,-1.691f);
		Instantiate (oOni_5,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator sixth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.977f,11.161f);
		Instantiate (oOni_6,startPos,Quaternion.Euler(0,0,0));
	}
}
