using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class FlyingCat : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 0, -10f * Time.unscaledDeltaTime, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("GAME OVER \n L in the chat");
            EditorApplication.isPlaying = false;
        }
    }
}