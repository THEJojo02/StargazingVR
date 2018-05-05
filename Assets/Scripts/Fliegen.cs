using UnityEngine;
using UnityEngine.SceneManagement;

public class Fliegen : MonoBehaviour {

    public Rigidbody rb;
    public float TheForce = -150f;
    public float time = 0;

    private void Start()
    {
        rb.AddForce(250 , 0, -500);
    }

    void FixedUpdate()
    {
        if (time < 8) {
            rb.AddForce(-1 * TheForce / 3 * Time.deltaTime, 0, TheForce * Time.deltaTime); // DIE Macht wird angewendet
        }
        else if (time > 8) {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
        time = Time.deltaTime + time;
    }
}
