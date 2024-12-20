using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] unitTypes;
    [SerializeField] float spawncooldown;
    private float time;

    void Update()
    {
        if (time >= spawncooldown)
        {
            time -= spawncooldown;

            int i = Random.Range(0, unitTypes.Length);
            GameObject.Instantiate(unitTypes[i], 
                new Vector3
                (
                transform.position.x - transform.localScale.x,
                1f,
                Random.Range(-4, 4)
                ), Quaternion.identity);
        }

        time += Time.deltaTime;
    }
}
