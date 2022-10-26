using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class ForInputs : MonoBehaviour
{

    public GameObject ball;

    public void OnFire(InputAction.CallbackContext context)
    {
        Vector3 ballPosition = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(1, 2.5f), Random.Range(-2.5f, 2.5f));
        Instantiate(ball, ballPosition, Quaternion.identity);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0);
        }
    }

}
