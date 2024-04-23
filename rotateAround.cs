using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rotateAround : MonoBehaviour
{
    public bool isRotating = false;
    public int speed = 5;
    public GameObject rot;

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
    }

    public void EnableDisableRotation()
    {
        isRotating = !isRotating;
        if (isRotating)
        {
            rot.SetActive(true);
        }
        else{
            rot.SetActive(false);
        }
    }
}
