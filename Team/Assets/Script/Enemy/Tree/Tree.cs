using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {
	public GameObject oTree_1;
	public GameObject oTree_2;
	public GameObject oTree_3;
	public GameObject oTree_4;
	public GameObject oTree_5;
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
			Live=true;
		}
		//}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,-0.728346f+0.1f,-7.779f);
		Instantiate (oTree_1,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,3.565f+0.1f,-3.72f);
		Instantiate (oTree_2,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.093988f+0.1f,2.336678f);
		Instantiate (oTree_3,startPos,Quaternion.Euler(0,180,0));
	}
	
	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.17273f+0.1f,1.063983f);
		Instantiate (oTree_4,startPos,Quaternion.Euler(0,180,0));
	}

	IEnumerator fifth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.09f,2.953f+0.1f,10.13f);
		Instantiate (oTree_5,startPos,Quaternion.Euler(0,0,0));
	}
}
