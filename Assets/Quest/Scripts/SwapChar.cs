using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapChar : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public Movement FirstChar;
    public Movement SecondChar;

    void Start()
    {
        camera1.SetActive(true);
        FirstChar.enabled = true;
        camera2.SetActive(false);
        SecondChar.enabled = false;
            
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            camera1.SetActive(false);
            FirstChar.enabled = false;
            camera2.SetActive(true);
            SecondChar.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            camera1.SetActive(true);
            FirstChar.enabled = true;
            camera2.SetActive(false);
            SecondChar.enabled = false;
        }
    }
}
