using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 PlayerInput; //een var voor de input in op te slaan
    public float Speed; //een var voor de snelheid 

    private void Start()
    {
        
    }

    void Update()
    {
        PlayerInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); //vraagt de input van de user
        transform.Translate(PlayerInput * Speed * Time.deltaTime); //beweegt de speler volgens de input
    }
}