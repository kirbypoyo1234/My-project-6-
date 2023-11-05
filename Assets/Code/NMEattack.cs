using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NMEattack : MonoBehaviour
{

    public GameObject pewpew;
    public GameObject loser;

    private void Start()
    {
        loser = GameObject.Find("Manager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            Instantiate(pewpew, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            loser.GetComponent<LOSE>().Defeat();
        }
    }
}
