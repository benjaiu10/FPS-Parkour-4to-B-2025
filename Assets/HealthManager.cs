using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float HP;
    public UIManager uiManager;

    // Start is called before the first frame update
    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealthText(float damage)
    {
        if (HP <= damage)
        {
            SceneManager.LoadScene("Parkour");
            return false;
        }
        else
        {
            HP -= damage;
            uiManager.UpdateHealthText(HP.ToString());
            return true;
        }
    }
}
