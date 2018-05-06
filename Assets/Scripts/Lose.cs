using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{  float time;

    public void Outro()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
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
