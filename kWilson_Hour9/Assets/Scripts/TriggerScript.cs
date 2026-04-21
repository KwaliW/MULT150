using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            print("ENTER: " + other.gameObject.name + " hit " + gameObject.name);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            print("STAY: " + other.gameObject.name + " in " + gameObject.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            print("EXIT: " + other.gameObject.name + " left " + gameObject.name);
        }
    }
}