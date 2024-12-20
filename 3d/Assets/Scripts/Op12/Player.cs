using UnityEngine;

public class Player : Unit
{
    [SerializeField] float rotationSpeed;

    public override void Move()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
