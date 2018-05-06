using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    float time;

    public void Outro()
    {
        SceneManager.LoadScene("Outro", LoadSceneMode.Single);
    }


     void Update()
    {
        time = Time.deltaTime + time;
        if (time > 20)
        {
            Outro();
        }
    }

}
