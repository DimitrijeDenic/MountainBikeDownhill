
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraStopFollow : MonoBehaviour
{

    public CameraMovement camera;

    private void Start()
    {
        camera = GameObject.FindWithTag("MainCamera").GetComponent<CameraMovement>();
        camera.enabled = false;
    }

    private void OnTriggerEnter(Collider colider)
    {

        if (colider.transform.tag == "Player")
        {
            Debug.Log("dead");
            camera.enabled = false;
            Invoke("Restart", 2f);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene("Menu");
    }
}
