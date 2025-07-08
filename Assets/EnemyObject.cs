using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    public HealthManager HealthManager;
    public float Damage;

    // Start is called before the first frame update
    private void Start()
    {
        HealthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HealthManager.UpdateHealthText(Damage))
            {
                Destroy(gameObject);
            }
        }
    }
}
