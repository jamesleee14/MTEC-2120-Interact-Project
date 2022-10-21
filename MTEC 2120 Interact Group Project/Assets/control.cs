using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    [SerializeField]
    private GameObject particles;
    private Vector2 mousePos;

    private void start()
    {
        particles.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            particles.SetActive(true);
            particles.transform.position = new Vector3(mousePos.x, mousePos.y, 0f); ;
        }
        if (Input.GetMouseButtonUp(0))
        {
            particles.SetActive(false);
        }
    }

}