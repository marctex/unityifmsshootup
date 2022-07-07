using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public GameObject shoot;
    void Start()
    {
        InvokeRepeating("Disparar", 0, Random.Range(2, 10));
    }

    void Disparar()
    {
        Instantiate(shoot, this.transform.position, Quaternion.identity);
    }
   
}
