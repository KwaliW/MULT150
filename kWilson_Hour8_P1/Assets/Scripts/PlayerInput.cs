using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    void Update()
    {
        // Movement input (keyboard)
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (hVal != 0)
        {
            print("Horizontal movement selected: " + hVal);
        }

        if (vVal != 0)
        {
            print("Vertical movement selected: " + vVal);
        }

        // Key input (hold M)
        if (Input.GetKey(KeyCode.M))
        {
            print("The M key is pressed down");
        }

        // Key input (press O once)
        if (Input.GetKeyDown(KeyCode.O))
        {
            print("The O key was pressed");
        }

        // Mouse input
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        if (mxVal != 0)
        {
            print("Mouse X movement selected: " + mxVal);
        }

        if (myVal != 0)
        {
            print("Mouse Y movement selected: " + myVal);
        }
    }
}