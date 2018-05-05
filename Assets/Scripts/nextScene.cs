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

	// Update wird einmal pro Bild geladen
	void Update () {

        //überprüft Planeten, wenn sie ungleich nichts sind wird geprüft ob sie gesnappt sind mit dem andren Skript
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


		// wenn alle richtig gesnappt -> Aufgabe 1 gelöst
		if ((finishedsonne==true) && (finishedneptun==true) && (finishedsaturn==true) && (finishedjupiter==true)
			&& (finishedvenus==true) && (finishederde==true)
			&& (finishedmars==true) && (finishedmerkur==true)  && (finisheduranus==true))
		{
            // läd Button zum Scenenwechsel
			Pfeil.SetActive(true);
			Kugel.SetActive(true);
		}
		
	}
     
    // Entläd die 1.Aufgabe ruft andere Funktion auf
	public void NextTask()
	{	
		SceneManager.UnloadSceneAsync("Aufgabe1");
		LoadNextScene();
	}
    // läd die 2.Aufgabe wieder additive
	public void LoadNextScene()
	{
		SceneManager.LoadScene ("Aufgabe2", LoadSceneMode.Additive);
	}


}
