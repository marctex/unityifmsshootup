using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerPlayer : MonoBehaviour
{
    public GameObject target;
    public float speed;
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            Vector3 pos = target.transform.position - this.transform.position;
            Vector3 velo = pos.normalized * speed;
            this.transform.Translate(velo * Time.deltaTime);
        }
           
    }


}
