using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyOnaLeash : MonoBehaviour
{
    public GameObject Star;
    public float shootInterval = 2;
    public float shootTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        shootTimer -= Time.deltaTime;
        Shoot();
    }
    void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = realPos;
        transform.LookAt(realPos);
    }

    void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (shootTimer <= 0)
            {
                shootTimer = shootInterval;
                Instantiate(Star, transform.position, Quaternion.identity);
            }
            
        }
        
        
    }

   
}
