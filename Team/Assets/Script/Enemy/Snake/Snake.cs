using UnityEngine;
using System.Collections;

public class Snake : MonoBehaviour {
	public GameObject oSnake_1;
	public GameObject oSnake_2;
	public GameObject oSnake_3;
	public GameObject oSnake_4;
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
			Live=true;
		}
		//}
	}
	
	IEnumerator first_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.19f,-4.022107f,-11.6f);
		Instantiate (oSnake_1,startPos,Quaternion.Euler(0,90,0));
	}

	IEnumerator second_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.19f,-4.022107f,-12.65f);
		Instantiate (oSnake_2,startPos,Quaternion.Euler(0,270,0));
	}


	IEnumerator third_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.19f,3.59f,-2.129f);
		Instantiate (oSnake_3,startPos,Quaternion.Euler(0,90,0));
	}

	IEnumerator forth_create(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		startPos = new Vector3 (0.19f,3.59f,-1.675f);
		Instantiate (oSnake_4,startPos,Quaternion.Euler(0,90,0));
	}
}
