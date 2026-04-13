using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}