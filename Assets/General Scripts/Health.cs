using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount, PawnClass source)
    {
        CurrentHealth = CurrentHealth - amount;
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        if (CurrentHealth <= 0)
        {
            Die(source);
        }
    }

    public void Die(PawnClass source)
    {
        Destroy(gameObject);
    }
}
