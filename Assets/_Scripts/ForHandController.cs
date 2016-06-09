using UnityEngine;
using System.Collections;

public class ForHandController : MonoBehaviour {

	public GameObject HandController1;

	public static float ib1x;
	public static float ib1y;
	public static float ib1z;

	public static float ib2x;
	public static float ib2y;
	public static float ib2z;
	
	public static float ib3x;
	public static float ib3y;
	public static float ib3z;

	public static float mb1x;
	public static float mb1y;
	public static float mb1z;
	
	public static float mb2x;
	public static float mb2y;
	public static float mb2z;
	
	public static float mb3x;
	public static float mb3y;
	public static float mb3z;

	public static float rb1x;
	public static float rb1y;
	public static float rb1z;
	
	public static float rb2x;
	public static float rb2y;
	public static float rb2z;
	
	public static float rb3x;
	public static float rb3y;
	public static float rb3z;

	public static float pb1x;
	public static float pb1y;
	public static float pb1z;
	
	public static float pb2x;
	public static float pb2y;
	public static float pb2z;
	
	public static float pb3x;
	public static float pb3y;
	public static float pb3z;

	public static float tb1x;
	public static float tb1y;
	public static float tb1z;
	
	public static float tb2x;
	public static float tb2y;
	public static float tb2z;
	
	public static float tb3x;
	public static float tb3y;
	public static float tb3z;


	GameObject rHand = null;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rHand = GameObject.Find ("RigidHand(Clone)");

		if (rHand != null) {
						Debug.Log ("Not null");

			//Debug.Log (rHand.transform.FindChild("index").FindChild("bone3").eulerAngles.x);

			ib1x = rHand.transform.FindChild("index").FindChild("bone1").eulerAngles.x;
			ib1y = rHand.transform.FindChild("index").FindChild("bone1").eulerAngles.y;
			ib1z= rHand.transform.FindChild("index").FindChild("bone1").eulerAngles.z;
			
			ib2x= rHand.transform.FindChild("index").FindChild("bone2").eulerAngles.x;
			ib2y= rHand.transform.FindChild("index").FindChild("bone2").eulerAngles.y;
			ib2z= rHand.transform.FindChild("index").FindChild("bone2").eulerAngles.z;
			
			ib3x= rHand.transform.FindChild("index").FindChild("bone3").eulerAngles.x;
			ib3y= rHand.transform.FindChild("index").FindChild("bone3").eulerAngles.y;
			ib3z= rHand.transform.FindChild("index").FindChild("bone3").eulerAngles.z;
			
			mb1x= rHand.transform.FindChild("middle").FindChild("bone1").eulerAngles.x;
			mb1y= rHand.transform.FindChild("middle").FindChild("bone1").eulerAngles.y;
			mb1z= rHand.transform.FindChild("middle").FindChild("bone1").eulerAngles.z;
			
			mb2x= rHand.transform.FindChild("middle").FindChild("bone2").eulerAngles.x;
			mb2y= rHand.transform.FindChild("middle").FindChild("bone2").eulerAngles.y;
			mb2z= rHand.transform.FindChild("middle").FindChild("bone2").eulerAngles.z;
			
			mb3x= rHand.transform.FindChild("middle").FindChild("bone3").eulerAngles.x;
			mb3y= rHand.transform.FindChild("middle").FindChild("bone3").eulerAngles.y;
			mb3z= rHand.transform.FindChild("middle").FindChild("bone3").eulerAngles.z;
			
			rb1x= rHand.transform.FindChild("ring").FindChild("bone1").eulerAngles.x;
			rb1y= rHand.transform.FindChild("ring").FindChild("bone1").eulerAngles.y;
			rb1z= rHand.transform.FindChild("ring").FindChild("bone1").eulerAngles.z;
			
			rb2x= rHand.transform.FindChild("ring").FindChild("bone2").eulerAngles.x;
			rb2y= rHand.transform.FindChild("ring").FindChild("bone2").eulerAngles.y;
			rb2z= rHand.transform.FindChild("ring").FindChild("bone2").eulerAngles.z;
			
			rb3x= rHand.transform.FindChild("ring").FindChild("bone3").eulerAngles.x;
			rb3y= rHand.transform.FindChild("ring").FindChild("bone3").eulerAngles.y;
			rb3z= rHand.transform.FindChild("ring").FindChild("bone3").eulerAngles.z;
			
			pb1x= rHand.transform.FindChild("pinky").FindChild("bone1").eulerAngles.x;
			pb1y= rHand.transform.FindChild("pinky").FindChild("bone1").eulerAngles.y;
			pb1z= rHand.transform.FindChild("pinky").FindChild("bone1").eulerAngles.z;
			
			pb2x= rHand.transform.FindChild("pinky").FindChild("bone2").eulerAngles.x;
			pb2y= rHand.transform.FindChild("pinky").FindChild("bone2").eulerAngles.y;
			pb2z= rHand.transform.FindChild("pinky").FindChild("bone2").eulerAngles.z;
			
			pb3x= rHand.transform.FindChild("pinky").FindChild("bone3").eulerAngles.x;
			pb3y= rHand.transform.FindChild("pinky").FindChild("bone3").eulerAngles.y;
			pb3z= rHand.transform.FindChild("pinky").FindChild("bone3").eulerAngles.z;
			
			tb1x= rHand.transform.FindChild("thumb").FindChild("bone1").eulerAngles.x;
			tb1y= rHand.transform.FindChild("thumb").FindChild("bone1").eulerAngles.y;
			tb1z= rHand.transform.FindChild("thumb").FindChild("bone1").eulerAngles.z;
			
			tb2x= rHand.transform.FindChild("thumb").FindChild("bone2").eulerAngles.x;
			tb2y= rHand.transform.FindChild("thumb").FindChild("bone2").eulerAngles.y;
			tb2z= rHand.transform.FindChild("thumb").FindChild("bone2").eulerAngles.z;
			
			tb3x= rHand.transform.FindChild("thumb").FindChild("bone3").eulerAngles.x;
			tb3y= rHand.transform.FindChild("thumb").FindChild("bone3").eulerAngles.y;
			tb3z= rHand.transform.FindChild("thumb").FindChild("bone3").eulerAngles.z;



				}


	
	}

	void OnEnable()
	{
		HandController1.SetActive (true);
		HandController1.GetComponent<HandController> ().UnhideAllHands ();
	}

	void OnDisable()
	{
		HandController1.GetComponent<HandController> ().HideAllHands ();
		HandController1.SetActive (false);
	}



}
