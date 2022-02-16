using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {
	public GameObject oCloud;
	float Cloud_Speed;
	// Use this for initialization
	void Start () {
		Cloud_Speed = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (oCloud.gameObject.name == "구름") {
			if(oCloud.transform.localPosition.z<=0.234)
				Cloud_Speed=0.7f;
			if(oCloud.transform.localPosition.z>=2.234)
				Cloud_Speed=-0.7f;
		}

		if (oCloud.gameObject.name == "구름1") {
			if(oCloud.transform.localPosition.z<=0.767)
				Cloud_Speed=0.5f;
			if(oCloud.transform.localPosition.z>=1.767)
				Cloud_Speed=-0.5f;
		}

		if (oCloud.gameObject.name == "구름2") {
			if(oCloud.transform.localPosition.z<=6.4)
				Cloud_Speed=0.4f;
			if(oCloud.transform.localPosition.z>=6.9)
				Cloud_Speed=-0.4f;
		}

		if (oCloud.gameObject.name == "구름3") {
			if(oCloud.transform.localPosition.z<=7.2)
				Cloud_Speed=0.5f;
			if(oCloud.transform.localPosition.z>=7.6)
				Cloud_Speed=-0.5f;
		}

		if (oCloud.gameObject.name == "구름4") {
			if(oCloud.transform.localPosition.z<=7.62)
				Cloud_Speed=0.7f;
			if(oCloud.transform.localPosition.z>=8.12)
				Cloud_Speed=-0.7f;
		}



		transform.Translate (Vector3.forward * Time.deltaTime*Cloud_Speed, Space.World);
	}
}
