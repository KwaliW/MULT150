using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("ColourChange");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Scale");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Spin");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Hover");
        }
    }
}