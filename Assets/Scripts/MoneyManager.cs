using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //impedir la compra
            Debug.Log("Dinero");
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
        }
    }
    
}
