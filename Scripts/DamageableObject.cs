using UnityEditor;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    [Header("Debug")]
    public bool debugMode = false;

    [Header("Health Stats")]
    public float currentHealth = 0.0f;
    public float maximumHealth = 100.0f;

    public bool canTakeDamage = true;

    [Header("Effects")]
    public GameObject hitTakenParticlePrefab = null;

    private void Awake()
    {
        currentHealth = maximumHealth;
    }

    public virtual void TakeDamage(float damageToDeal, Vector3 direction, Vector3 hitPoint)
    {
        if (canTakeDamage)
        {
            currentHealth -= damageToDeal;
        }

        GameObject hitParticles = Instantiate(hitTakenParticlePrefab, hitPoint, Quaternion.identity);
        hitParticles.transform.rotation = Quaternion.LookRotation(-direction);
        Destroy(hitParticles, 15f);

        if (currentHealth <= 0.0f)
        {
            Death();
        }
    }

    public virtual void Death()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        if(debugMode)
        {
            Vector3 debugTextPosition = new Vector3(transform.position.x - 1f, transform.position.y + 2f, transform.position.z);
            Handles.Label(debugTextPosition, "HP: " + currentHealth.ToString("N0"));
        }
    }
}
