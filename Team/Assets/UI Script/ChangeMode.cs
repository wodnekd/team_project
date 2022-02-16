using UnityEngine;
using System.Collections;

public class ChangeMode : MonoBehaviour {
	public GameObject goSaem;

	public static bool bTiger;
	public static bool bFire_Bird;
	public static bool bBlueDragon;
	public static bool bWaterSnake;
//	Animator anim;

	// Use this for initialization
	void Start () {
		//anim = GetComponent <Animator>();
		bTiger = false;
		bFire_Bird = false;
		bBlueDragon = false;
		bWaterSnake = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BlueDragon()
	{
		bTiger = false;
		bBlueDragon = true;
	}

	public void WhiteTiger()
	{
		bTiger = true;
		//Physics.gravity=new Vector3(0,0.0f,0);
	}

	public void WaterSnake()
	{
		Character_Hp.nHP = Character_Hp.nHP + 1;
	}

	public void FireBird()
	{
		bFire_Bird = true;
	}
}
