using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;

    [Header("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phaseCooldown = 2f;

    Renderer mesh;
    Collider playerCollider;

    bool canPhase = true;

    void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        playerCollider = GetComponent<Collider>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") *
                      Time.deltaTime *
                      strafeSpeed;

        Vector3 position = transform.position;

        position.x += xMove;
        position.x = Mathf.Clamp(position.x, -bounds, bounds);

        transform.position = position;

        if (Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;

            mesh.material = phasedMat;
            playerCollider.enabled = false;

            Invoke("PhaseIn", phaseCooldown);
        }
    }

    void PhaseIn()
    {
        canPhase = true;

        mesh.material = normalMat;
        playerCollider.enabled = true;
    }
}