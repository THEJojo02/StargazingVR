using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public void LoadScenea()
	{
		SceneManager.LoadScene ("Aufgabe1", LoadSceneMode.Additive);
	}

	void Start () {
		LoadScenea ();
	}
	

}
