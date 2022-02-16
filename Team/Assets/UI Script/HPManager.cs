using UnityEngine;
using System.Collections;

public class HPManager : MonoBehaviour {
	public GameObject Hp_Num1;
	public GameObject Hp_Num2;
	public GameObject Hp_Num3;
	public GameObject Hp_Num4;
	public GameObject Hp_Num5;
	// Use this for initialization
	void Start () {
		Hp_Num1.SetActive(false);
		Hp_Num2.SetActive(false);
		Hp_Num3.SetActive(false);
		Hp_Num4.SetActive(false);
		Hp_Num5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Character_Hp.nHP == 1) {
			Hp_Num1.SetActive(true);
			Hp_Num2.SetActive(false);
			Hp_Num3.SetActive(false);
			Hp_Num4.SetActive(false);
			Hp_Num5.SetActive(false);
		}
		else if (Character_Hp.nHP == 2) {
			Hp_Num1.SetActive(true);
			Hp_Num2.SetActive(true);
			Hp_Num3.SetActive(false);
			Hp_Num4.SetActive(false);
			Hp_Num5.SetActive(false);
		}

		else if (Character_Hp.nHP == 3) {
			Hp_Num1.SetActive(true);
			Hp_Num2.SetActive(true);
			Hp_Num3.SetActive(true);
			Hp_Num4.SetActive(false);
			Hp_Num5.SetActive(false);
		}

		else if (Character_Hp.nHP == 4) {
			Hp_Num1.SetActive(true);
			Hp_Num2.SetActive(true);
			Hp_Num3.SetActive(true);
			Hp_Num4.SetActive(true);
			Hp_Num5.SetActive(false);
		}

		else if (Character_Hp.nHP == 5) {
			Hp_Num1.SetActive(true);
			Hp_Num2.SetActive(true);
			Hp_Num3.SetActive(true);
			Hp_Num4.SetActive(true);
			Hp_Num5.SetActive(true);
		}
	}
}
