
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider colider)
    {
        if (colider.transform.tag == "obsticle")
        {
            Debug.Log("dead");
            Destroy(this);
            SceneManager.LoadScene("Menu");
        }
    }
}
