using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Rotation : MonoBehaviour {


	public GameObject Bahn;
	public float speed;
	public GameObject DropZone;
	string dz;


	void OrbitAround(){

		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
	}

	bool isSnapped;

	void Update () {

		dz = DropZone.name;
		GameObject snap = GameObject.Find("JupiterSnapZone");
		isSnapped = snap.GetComponent<VRTK_SnapDropZone> ().isSnapped; //isSnapped(bool) aus dem Script der SnapDropZone
		if (isSnapped == true) {
			
			OrbitAround (); 
			//rotieren, wenn Planet an richtiger Stelle
		}
	}
}
