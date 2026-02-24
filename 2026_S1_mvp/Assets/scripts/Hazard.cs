using UnityEngine;

public class Hazard : MonoBehaviour
{
    public float damage = 25;
    

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch! Damage is: " + damage);  
    }
}
