using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class snap_allowed : MonoBehaviour {


	Vector3 posleft;
	public Vector3 posright;
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

	void Update () {
		//Controller finden und deren Position einer Variable zuweisen
		GameObject left = GameObject.Find ("LeftController");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;

		GameObject right = GameObject.Find ("RightController");
		posright = right.GetComponent<PositionRightHand> ().positionright;

		//prüfen, ob ein Planet gegriffen ist
		var planetgrabbed = planet.GetComponentInParent<VRTK_InteractableObject> ();
		objectisgrabbed = planetgrabbed.IsGrabbed ();

		//ausrechnen der Distanz
		if (objectisgrabbed == true) {
			Distanceri = Vector3.Distance (posright, center);
			Distancele = Vector3.Distance (posleft, center);
		//SnapDropZone aktiv/deaktiv setzen
			if (allowsnap == true){
				if (objectisgrabbed == true && (Distancele < alloweddistance | Distanceri < alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = false;
					GetComponent<SphereCollider>().enabled = false;
				}
				if (objectisgrabbed == true && (Distancele > alloweddistance | Distanceri > alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = true;
					GetComponent<SphereCollider>().enabled = true;

				}
			}
		}

	}
}
