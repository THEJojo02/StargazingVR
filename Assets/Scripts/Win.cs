using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    public void Outro()
    {
        SceneManager.LoadScene("Outro", LoadSceneMode.Single);
    }

    void Start()
    {
        Outro();
    }

}
