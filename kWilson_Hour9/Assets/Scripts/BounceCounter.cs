using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            count++;
            Debug.Log("Bounce count: " + count);
        }
    }
}