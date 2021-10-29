using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggering : MonoBehaviour

{
    public GameObject Red_Ball;
    public GameObject Yellow_Ball;

    private void OnTriggerEnter(Collider other)
    {
        Red_Ball.SetActive(true);
        Yellow_Ball.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Red_Ball.SetActive(false);
        Yellow_Ball.SetActive(true);
    }






}



