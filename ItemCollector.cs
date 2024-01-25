using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    int keys = 0;
    [SerializeField] Text inventoryText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            Debug.Log("Coins: " + coins);
        }

        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            keys++;
            Debug.Log("Keys: " + keys);
        }
        
        // inventoryText.text = "Coins: " + coins + ", Keys: " + keys;


    }


}
