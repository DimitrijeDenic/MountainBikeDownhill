using System.Collections;

using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public int countdown;
    public Text display;
    public float speed;
    public Movement script;
    public CameraMovement script1;
    public StaticCameraMove script2;
    




    private void Start()
    {
        StartCoroutine(CountdownStart());

        script = GameObject.FindWithTag("Player").GetComponent<Movement>();
        script1 = GameObject.FindWithTag("MainCamera").GetComponent<CameraMovement>();
        script2 = GameObject.FindWithTag("MainCamera").GetComponent<StaticCameraMove>();


        script.enabled = false;
        script1.enabled = false;
        script2.enabled = false;




    }

    
    IEnumerator CountdownStart()
    {
        while(countdown > 0)
        {
            display.text = countdown.ToString();

            yield return new WaitForSeconds(1f);

            countdown--;

        }

        display.text ="GO!";
        
        yield return new WaitForSeconds(1f);
        display.gameObject.SetActive(false);
        script.enabled = true;
        script1.enabled = true;
        script1.enabled = true;



    }
}


