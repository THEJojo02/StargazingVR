using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

	public bool finishedtask1;
	public bool finishedtask2;
	public GameObject Kugel;
	public GameObject Pfeil;
	public GameObject sonne;
	public GameObject stern;
	// Update is called once per frame
	void Update () {

		finishedtask1 = sonne.GetComponent<Rotation> ().task1finished; 
		finishedtask2 = stern.GetComponent<Aufgabe2> ().task2finished; 
		
		if (finishedtask1==true){
			Debug.Log ("snapped");
			Pfeil.SetActive(true);
			Kugel.SetActive(true);
		}
		if (finishedtask2==true){
			Debug.Log ("snapped");
			Pfeil.SetActive(true);
			Kugel.SetActive(true);
		}
		
	}

	public void NextTask()
	{	
		SceneManager.UnloadScene ("Aufgabe1");
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
