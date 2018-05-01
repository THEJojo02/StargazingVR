using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

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
	public bool task1finish;

	void Update () {
		//prüfen, ob Planeten an richtiger Stelle
		//rotieren, wenn Planet an richtiger Stelle
		if (isSnappedmerkur == true) {
			RotationPlaneten (); 
		}
		if (isSnappedv == true) {
			RotationPlaneten ();
		}
		if (isSnappede == true) {
			RotationPlaneten ();
		}
		if (isSnappedma == true) {
			RotationPlaneten (); 
		}
		if (isSnappedj == true) {
			RotationPlaneten (); 
		}
		if (isSnappeds == true) {
			RotationPlaneten (); 
		}
		if (isSnappedu == true) {
			RotationPlaneten (); 
		}
		if (isSnappedn == true) {
			RotationPlaneten (); 
			Debug.Log ("neptun");
		}
		if ((isSnappedmerkur == true) && (isSnappedv == true) && (isSnappede == true) && (isSnappedma == true) && (isSnappedj == true) && (isSnappeds == true) &&
			(isSnappedu == true)&& (isSnappedn == true)) {

		}

		if (isSnappedso == true){
			if (isSnappedn == true){ 
			task1finish = true;
			RotationPlaneten ();
			}
		}
	}


	public void sonnesnapped(){
		isSnappedso = true;
		Debug.Log ("sonne");
	}
	public void merkursnapped(){
		isSnappedmerkur = true;
		Debug.Log ("merkur");
	}
	public void venussnapped(){
		isSnappedv = true;
		Debug.Log ("venus");
	}
	public void erdesnapped(){
		isSnappede = true;
		Debug.Log ("erde");
	}
	public void marssnapped(){
		isSnappedma = true;
		Debug.Log ("mars");
	}
	public void jupitersnapped(){
		isSnappedj = true;
		Debug.Log ("jupiter");
	}
	public void saturnsnapped(){
		isSnappeds = true;
		Debug.Log ("saturn");
	}
	public void uranussnapped(){
		isSnappedu = true;
		Debug.Log ("ura");
	}
	public void neptunsnapped(){
		isSnappedn = true;
		Debug.Log ("nept");
	}
		


	}

