using UnityEngine;
using System.Collections;

public class Bear : MonoBehaviour {
	public GameObject oBear_1;
	public GameObject oBear_2;
	public GameObject oBear_3;
	public GameObject oBear_4;
	public GameObject oBear_5;
	public GameObject oBear_6;
	public GameObject oBear_7;
	public GameObject oBear_8;
	public GameObject oBear_9;
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
		
		//if(Character.transform.position.y>-0.3f)
		//{
		if(Live==false)
		{
			StartCoroutine(first_create(0.2f));
			StartCoroutine(second_create(0.2f));
			StartCoroutine(third_create(0.2f));
			StartCoroutine(forth_create(0.2f));
			StartCoroutine(fifth_create(0.2f));
			StartCoroutine(sixth_create(0.2f));
			StartCoroutine(seventh_create(0.2f));
			StartCoroutine(eighth_create(0.2f));
			StartCoroutine(nineth_create(0.2f));
			Live=true;
		}
		//}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-3.101015f,-8.798616f);
		Instantiate (oBear_1,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-0.01272933f,-4.738952f);
		Instantiate (oBear_2,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.8644969f,-2.049f);
		Instantiate (oBear_3,startPos,Quaternion.Euler(0,0,0));
	}

	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.473f,-1.28f);
		Instantiate (oBear_4,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator fifth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.08994344f,5.336f);
		Instantiate (oBear_5,startPos,Quaternion.Euler(0,180,0));
	}
	
	IEnumerator sixth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-1.475441f,8.095f);
		Instantiate (oBear_6,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator seventh_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-0.9051839f,13.83944f);
		Instantiate (oBear_7,startPos,Quaternion.Euler(0,180,0));
	}
	
	IEnumerator eighth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.974f,13.579f);
		Instantiate (oBear_8,startPos,Quaternion.Euler(0,0,0));
	}
	
	IEnumerator nineth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.992f,12.146f);
		Instantiate (oBear_9,startPos,Quaternion.Euler(0,0,0));
	}
}
