using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        float mX = Input.GetAxis("Mouse X") / 3f;
        float mY = Input.GetAxis("Mouse Y") / 3f;

        Vector3 movement = new Vector3(h + mX, 0, v + mY);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}