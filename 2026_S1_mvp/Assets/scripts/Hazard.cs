using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float damage = 25;
    

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag ==  "player" )
        {
            other.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
