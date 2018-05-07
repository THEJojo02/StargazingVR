using UnityEngine;
using UnityEngine.SceneManagement;

public class FliegenOut : MonoBehaviour {

    public Rigidbody rb;
    public float TheForce = -150f;
    public float time = 0;

    private void Start()
    {
        rb.AddForce(-250 , 0, 500);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (time < 8) {
			rb.AddForce( 1 / 5 , 0, (TheForce * Time.deltaTime)/14); // DIE Macht wird angewendet
        }
        else if (time > 8) {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        time = Time.deltaTime + time;
    }
}
