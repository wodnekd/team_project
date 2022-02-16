using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {
	public GameObject oMouse_1;
	public GameObject oMouse_2;
	public GameObject oMouse_3;
	public GameObject oMouse_4;
	public GameObject oMouse_5;
	public GameObject oMouse_6;
	public GameObject oMouse_7;
	public GameObject oMouse_8;
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
			Live=true;
		}
		//}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-3.367509f,-12.937f);
		Instantiate (oMouse_1,startPos,Quaternion.Euler(-90,180,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.59f,-2.381f);
		Instantiate (oMouse_2,startPos,Quaternion.Euler(-90,180,0));
	}

	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.59f,-1.989f);
		Instantiate (oMouse_3,startPos,Quaternion.Euler(-90,180,0));
	}
	
	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.59f,-1.559f);
		Instantiate (oMouse_4,startPos,Quaternion.Euler(-90,180,0));
	}

	IEnumerator fifth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,00.2f,4.842f);
		Instantiate (oMouse_5,startPos,Quaternion.Euler(-90,180,0));
	}
	
	IEnumerator sixth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.2f,4.957f);
		Instantiate (oMouse_6,startPos,Quaternion.Euler(-90,180,0));
	}
	
	IEnumerator seventh_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.2f,4.521f);
		Instantiate (oMouse_7,startPos,Quaternion.Euler(-90,180,0));
	}
	
	IEnumerator eighth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,0.2f,4.1347f);
		Instantiate (oMouse_8,startPos,Quaternion.Euler(-90,180,0));
	}
}
