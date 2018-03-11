using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Rotation : MonoBehaviour {


	public GameObject Bahn; //Planetenbahn
	public float speed; //Rotationsgeschwindigkeit


	void RotationPlaneten(){

		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
	}

	void RotationSonne(){

		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
	}

	bool isSnappedso;
	bool isSnappedmerkur;
	bool isSnappedv;
	bool isSnappede;
	bool isSnappedma;
	bool isSnappedj;
	bool isSnappeds;
	bool isSnappedu;
	bool isSnappedn;

	void Update () {

		GameObject snapso = GameObject.Find("SonneSnapZone");
		isSnappedso = snapso.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snapme = GameObject.Find("MerkurSnapZone");
		isSnappedmerkur = snapme.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snapv = GameObject.Find("VenusSnapZone");
		isSnappedv = snapv.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snape = GameObject.Find("ErdeSnapZone");
		isSnappede = snape.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snapma = GameObject.Find("MarsSnapZone");
		isSnappedma = snapma.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snapj = GameObject.Find("JupiterSnapZone");
		isSnappedj = snapj.GetComponent<VRTK_SnapDropZone> ().isSnapped; 

		GameObject snapu = GameObject.Find("UranusSnapZone");
		isSnappedu = snapu.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snaps = GameObject.Find("SaturnSnapZone");
		isSnappeds = snaps.GetComponent<VRTK_SnapDropZone> ().isSnapped;

		GameObject snapn = GameObject.Find("NeptunSnapZone");
		isSnappedn = snapn.GetComponent<VRTK_SnapDropZone> ().isSnapped;//isSnapped(bool) aus dem Script der SnapDropZone

		//prüfen, ob Planeten an richtiger Stelle


		if (isSnappedmerkur == true &&  isSnappedv == true && isSnappede == true && isSnappedma == true && isSnappedj == true && isSnappeds == true &&
			isSnappedu == true && isSnappedn == true) {
			
			RotationPlaneten (); 
			//rotieren, wenn Planet an richtiger Stelle
		}

		if(isSnappedso == true){

			RotationSonne ();
		}
	}
}
