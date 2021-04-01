
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour { 

    public Text VictoryText;
    public string text = "Victory";

    private void Start()
    {
        VictoryText.gameObject.SetActive(false);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Victory");
            VictoryText.gameObject.SetActive(true);
            VictoryText.text = text;

            Invoke("HideText", 10f);

        }
    }
    void HideText()
    {
        VictoryText.gameObject.SetActive(false);
    }



}
