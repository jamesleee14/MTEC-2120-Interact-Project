using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ForInputs : MonoBehaviour
{

    public GameObject ball;

    public void Spawn(InputAction.CallbackContext context)
    {
        Vector3 ballPosition = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(1, 2.5f), Random.Range(-2.5f, 2.5f));
        Instantiate(ball, ballPosition, Quaternion.identity);
    }

    public void Restart(InputAction.CallbackContext context)
    {
        Application.LoadLevel(0);
    }

    public void changeColor(InputAction.CallbackContext context)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
