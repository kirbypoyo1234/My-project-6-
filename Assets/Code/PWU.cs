using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PWU : MonoBehaviour

{
    
    public GameObject powpow;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            GameManager.increasedMultiplier(0.9f);
            Destroy(gameObject);
            Instantiate(powpow, transform.position, transform.rotation);
        }
    }
}
