using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class snap_allowed : MonoBehaviour {


	Vector3 posleft;
	Vector3 posright;
	Vector3 center;
	bool objectisgrabbed;
	float Distanceri;
	float Distancele;
	public float alloweddistance;
	public GameObject planet;
	public bool allowsnap;	

	public void distance(){

		allowsnap = true;

	}
	
	// Update is called once per frame
	void Update () {
		GameObject left = GameObject.Find ("LeftController");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;

		GameObject right = GameObject.Find ("RightController");
		posright = right.GetComponent<PositionRightHand> ().positionright;

		var planetgrabbed = planet.GetComponentInParent<VRTK_InteractableObject> ();
		objectisgrabbed = planetgrabbed.IsGrabbed ();

		if (objectisgrabbed == true) {
			Distanceri = Vector3.Distance (posright, center);
			Distancele = Vector3.Distance (posleft, center);
		
			if (allowsnap == true){
				//Debug.Log (Distanceri);
				//Debug.Log (Distancele);
				if (objectisgrabbed == true && (Distancele < alloweddistance | Distanceri < alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = false;
					GetComponent<SphereCollider>().enabled = false;
					//Debug.Log ("no");
				}
				if (objectisgrabbed == true && (Distancele > alloweddistance | Distanceri > alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = true;
					GetComponent<SphereCollider>().enabled = true;
					//Debug.Log ("yes");

				}
			}
		}

	}
}
