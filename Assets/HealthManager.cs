using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool HealthUpdate(int damageAmount)
    {
        if (healthPoints <= damageAmount)
        {
            Debug.Log("Game Over");
            return false; // Game Over
        }
        healthPoints -= damageAmount;
        uiManager.UpdateHealthText(healthPoints.ToString());
        return true; // Sigue vivo
    }
}
