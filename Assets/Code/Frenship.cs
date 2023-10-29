using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frenship : MonoBehaviour
{
    public GameObject puwpuw;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("NME"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(puwpuw, transform.position, transform.rotation);
        }
    }
}
