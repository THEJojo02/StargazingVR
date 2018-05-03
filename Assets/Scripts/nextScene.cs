using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

	 bool finishedsonne;
	 bool finishedneptun;
	 bool finishedmerkur;
	 bool finishedvenus;
	 bool finishederde;
	 bool finishedmars;
	 bool finishedjupiter;
	 bool finishedsaturn;
	 bool finisheduranus;
	public GameObject Kugel;
	public GameObject Pfeil;
	public GameObject sonne;
	public GameObject neptun;
	public GameObject merkur;
	public GameObject venus;
	public GameObject erde;
	public GameObject mars;
	public GameObject jupiter;
	public GameObject saturn;
	public GameObject uranus;
	public GameObject stern;
	// Update is called once per frame
	void Update () {

		if (sonne != null){
			finishedsonne = sonne.GetComponent<Rotation> ().task1finish; 
		}
		if (neptun != null){
			finishedneptun = neptun.GetComponent<Rotation> ().finishn;}
		
		if (merkur != null){
			finishedmerkur = merkur.GetComponent<Rotation> ().finishmer;}
		
		if (venus != null){
			finishedvenus = venus.GetComponent<Rotation> ().finishve;}
		
		if (erde != null){
			finishederde = erde.GetComponent<Rotation> ().finisher;}
		
		if (mars != null){
			finishedmars = mars.GetComponent<Rotation> ().finishmar;}
		
		if (jupiter != null){
			finishedjupiter = jupiter.GetComponent<Rotation> ().finishju;}
		
		if (saturn != null){
			finishedsaturn = saturn.GetComponent<Rotation> ().finishsa;}
		
		if (uranus != null){
			finisheduranus = uranus.GetComponent<Rotation> ().finishur;}
		
		if ((finishedsonne==true) && (finishedneptun==true) && (finishedsaturn==true) && (finishedjupiter==true)
			&& (finishedvenus==true) && (finishederde==true)
			&& (finishedmars==true) && (finishedmerkur==true)  && (finisheduranus==true))
		{
			Debug.Log ("snappedfi");
			Pfeil.SetActive(true);
			Kugel.SetActive(true);
		}
	/*	if (finishedtask2==true){
			Debug.Log ("snapped");
			Pfeil.SetActive(true);
			Kugel.SetActive(true);
		}*/
		
	}

	public void NextTask()
	{	
		SceneManager.UnloadSceneAsync("Aufgabe1");
		LoadNextScene();
	}
	public void LoadNextScene()
	{
		SceneManager.LoadScene ("Aufgabe2", LoadSceneMode.Additive);
	}

	public void LoadgoodOutro(){
	}

	public void LoadbadOutro(){
	}


}
