using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{

    public void Outro()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    void Start()
    {
        Outro();
    }

}
