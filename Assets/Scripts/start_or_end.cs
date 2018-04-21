using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_or_end : MonoBehaviour {

	public void start(){
		SceneManager.LoadScene ("Brief", LoadSceneMode.Single);
	}

	public void end(){
		Application.Quit ();
	}

}
