using UnityEngine;
using System.Collections;

public class Lope : MonoBehaviour {
	public Collider cLope;
	public Rigidbody rSaem;
	public static bool bLoop;
	public GameObject oSam;
	bool bRot;
	float fRot;


	float cnt;
	float cnt2;
	float Lope_Time;
	float tRot;

    // Use this for initialization
    void Start () {
		bLoop = false;
		cnt = 0.0f;
		cnt2 = 0.0f;
		Lope_Time=0.3f;
		bRot = false;
		tRot = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
		if (bLoop == true) {
			if(Input.GetButton("Jump"))
				Move_Character.speed=1.0f;
			else
				Move_Character.speed=0.0f;
		}
		if(cnt>0) 
		{ 
			cnt -= Time.deltaTime; 
			if (cnt <0.0f){
				cnt = 0.0f; 
			}
		}

		if(cnt2>0) 
		{ 
			cnt2 -= Time.deltaTime; 
			if (cnt2 <0.0f){
				cnt2 = 0.0f; 
			}
		}
	
	}
	void OnTriggerEnter(Collider cLope)
	{
		if (cnt2 == 0) {
			if (cLope.gameObject.name == "덩굴" && (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow))) {
				if (Move_Character.Right == true)
					fRot = -90.0f;
				else
					fRot=90.0f;
				oSam.transform.Rotate (Vector3.up * fRot, Space.World);
				bRot = true;
				cnt2=tRot;
            } 
		}
	}
	void OnTriggerStay(Collider cLope)
	{
		if(cnt == 0.0) 
		{ 
			if (cLope.gameObject.name == "덩굴" && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))) {
				//rSaem.useGravity = false;
				rSaem.isKinematic=true;
				bLoop=true;
			}
		} 
	}
	
	void OnTriggerExit(Collider cLope)
	{
		if (cLope.gameObject.name == "덩굴") {
			//rSaem.useGravity = true;
			rSaem.isKinematic=false;
			bLoop=false;
			Move_Character.speed=1.0f;
			cnt=Lope_Time;
			if(bRot==true)
			{
				oSam.transform.Rotate (Vector3.up * -fRot, Space.World);
				bRot=false;
			}
		}
	}
}
