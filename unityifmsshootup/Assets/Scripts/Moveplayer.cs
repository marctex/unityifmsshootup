using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    public float speed = 5;
    public GameObject shoot;   
    
    void Update()
    {
        //instancia o tiro ao acionar a tacla de espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = this.transform.position;
            Instantiate(shoot, pos, Quaternion.Euler(0, 0, 180));
        }
    }

    //controla o movimento do player pelas setas horizontais
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");

        Rigidbody2D r = this.GetComponent<Rigidbody2D>();
        r.velocity = new Vector3(hor, 0, 0) * speed;
    }
}
