using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth = 0;

    void Start()
    {
        currentHealth = maxHealth;
    }



    public void TakeDamage(float damage)
    {
        Debug.Log("Ouchie!!");

        currentHealth = currentHealth - damage;

        Debug.Log("My health now is: " + currentHealth);


        if (currentHealth <= 0)
        {
            Debug.Log("GAME OVER!!!");


            GetComponent<PlayerController>().enabled = false;
        }


    }

}
       
