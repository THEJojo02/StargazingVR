using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{ public float time;
	public float a;

    public void Gesamtszene()
    {
        SceneManager.LoadScene("Gesamtszene", LoadSceneMode.Single);
    }


    void Update()
    {
        time = Time.deltaTime + time;
        if (time > 20)
		{	
			Gesamtszene();

        }
    }
}
