using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poopoo : MonoBehaviour
{
    public GameObject enemy;
    public float Interval = 2;
    public float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randx = Random.Range(-4, 4);
        Vector3 pos = new Vector3(randx, transform.position.y, 0);

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Instantiate(enemy, pos, transform.rotation);
            Timer = Interval;
        } 
    }
}
