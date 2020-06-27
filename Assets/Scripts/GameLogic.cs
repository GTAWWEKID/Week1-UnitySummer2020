using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            if(Input.GetKeyDown("joystick " + i.ToString() + " button 0"))
            {
                //Player 1
                Debug.Log("Controller: " + i);
            }
            if (Input.GetKeyDown("joystick " + i.ToString() + " button 1"))
            {
                //Player 2
            }
        }
    }
}
