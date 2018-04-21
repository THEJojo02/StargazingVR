using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenenWechsel : MonoBehaviour {

    float time;
	
	// Update is called once per frame
	void Update () {
        if (time > 30)
        {
            SceneManager.LoadScene("Intro",LoadSceneMode.Single);
            
        }
        time = Time.deltaTime + time;	
	}
}
