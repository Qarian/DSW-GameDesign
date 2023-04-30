using UnityEngine;

public class InputMover : MonoBehaviour
{
    public float speed;

    float vertical;
    float horizontal;

    // Zmienne ktore sa referencjami do komponentow
    public Transform transformComponent;
    public Rigidbody rigidbodyComponent;

    private void Start()
    {
        // Ustawianie referencji
        transformComponent = transform;
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 position = transformComponent.position;
        Vector3 targetPosition = position + (new Vector3(horizontal, 0, vertical) * Time.fixedDeltaTime * speed);

        rigidbodyComponent.MovePosition(targetPosition);
    }
}
