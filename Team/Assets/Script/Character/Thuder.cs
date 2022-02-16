using UnityEngine;
using System.Collections;

public class Thuder : MonoBehaviour {
	public static bool Blue_Thuder;
	public static Vector3 Thunder_Vector;
	public GameObject oThuder;
	float cnt;
	float fThuder_Time;

	bool bDes;
	

	// Use this for initialization
	void Start () {
		Blue_Thuder = false;
		cnt = 0.0f;
		fThuder_Time = 0.5f;
		bDes = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (bDes);
		if (Blue_Thuder == true && cnt == 0.0f) {
			Instantiate (oThuder, Thunder_Vector + new Vector3 (0.0f, 0.25f, 0.4f), Quaternion.Euler (0, 90, 0));
			cnt = fThuder_Time; 
			
		} else if(Blue_Thuder ==true && cnt>0.0f){
			cnt -= Time.deltaTime; 
			if (cnt < 0.0f) {
				Blue_Thuder = false;
				ChangeMode.bBlueDragon = false;
				bDes=true;
				cnt = 0.0f; 
			}
		}

		if (bDes == true) {
			//GameObject.Destroy (oThuder.gameObject,0);
			//bDes=false;
		}
			
	}


}
