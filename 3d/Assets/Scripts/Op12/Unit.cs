using UnityEngine;

public class Unit : MonoBehaviour, IMovable, IDamagable
{
    [SerializeField] protected float moveSpeed;

    public int Health => throw new System.NotImplementedException();

    public virtual void Move()
    {
         transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }

    public void TakeDamage()
    {
        throw new System.NotImplementedException();
    }


    void Update()
    {
        Move();
    }
}
