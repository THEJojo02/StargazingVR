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
	public bool finishn;
	public bool finishsa;
	public bool finishmer;
	public bool finishmar;
	public bool finisher;
	public bool finishve;
	public bool finishur;
	public bool finishju;



	void Update () {
		//prüfen, ob Planeten an richtiger Stelle
		//rotieren, wenn Planet an richtiger Stelle
		if (isSnappedmerkur == true) {
			RotationPlaneten (); 
		}
		if (isSnappedv == true) {
			finishve = true;
			RotationPlaneten ();
		}
		if (isSnappede == true) {
			finisher = true;
			RotationPlaneten ();
		}
		if (isSnappedma == true) {
			finishmar = true;
			RotationPlaneten (); 
		}
		if (isSnappedj == true) {
			finishju = true;
			RotationPlaneten (); 
		}
		if (isSnappeds == true) {
			finishsa = true;
			RotationPlaneten (); 
		}
		if (isSnappedu == true) {
			finishur = true;
			RotationPlaneten (); 
		}
		if (isSnappedn == true) {
			RotationPlaneten (); 
			finishn = true;
			Debug.Log (finishn);
		}




		if (isSnappedso == true) {
			RotationSonne ();
			task1finish = true;
		}

}



	public void sonnesnapped(){
		isSnappedso = true;
		Debug.Log (isSnappedso);
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

