using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificulty : MonoBehaviour
{
    public GameObject obstacles1;
    public GameObject obstacles2;
    public GameObject obstacles3;
    public Movement move;

    public void Start()
    {
        obstacles1.SetActive(true);
        obstacles2.SetActive(false);
        obstacles3.SetActive(false);
        move = GameObject.FindWithTag("Player").GetComponent<Movement>();
    }
    public void babyMode()
    {
        obstacles1.SetActive(false);
        obstacles2.SetActive(false);
        obstacles3.SetActive(false);
        move.speed = 5f;
    }
    public void Easy()
    {
        obstacles1.SetActive(true);
        obstacles2.SetActive(false);
        obstacles3.SetActive(false);
        move.speed = 8f;
    }
    public void Normal()
    {
        obstacles1.SetActive(true);
        obstacles2.SetActive(true);
        obstacles3.SetActive(false);
        move.speed = 13f;
    }
    public void Hard()
    {
        obstacles1.SetActive(true);
        obstacles2.SetActive(true);
        obstacles3.SetActive(true);
        move.speed = 20f;
    }

}
