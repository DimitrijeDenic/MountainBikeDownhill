using UnityEngine;
using UnityEngine.UI;

public class Debugg : MonoBehaviour
{
    public static bool DebugMode = false;
    public GameObject DebugUI;
    public Movement movement;
    public Text speedValue;
    public GameObject cam1;
    public GameObject cam2;
    
    private void Start()
    {
        DebugUI.SetActive(false);
        movement = GameObject.FindWithTag("Player").GetComponent<Movement>();

        cam1.SetActive(true);
        cam2.SetActive(false);
        
        

    }

    private void Update()
    {
        if (Input.touchCount > 2)
        {
            if (DebugMode)
            {
                Resume();
            }
            else
            {
                Debuging();
            }

        }
        speedValue.text =  movement.speed.ToString();
    }
    public void Resume()
    {
        DebugUI.SetActive(false);
        Time.timeScale = 1f;
        DebugMode = false;
        movement.controlSpeed = 9f;
    }
    void Debuging()
    {
        DebugUI.SetActive(true);
        Time.timeScale = 0f;
        DebugMode = true;
        movement.controlSpeed = 0;
    }
    public void Static(bool toggle)
    {
        if (toggle == true)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}

