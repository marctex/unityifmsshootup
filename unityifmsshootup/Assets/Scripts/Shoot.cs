using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject explode;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("inimigo"))
        {
            Vector3 pos = collision.transform.position;
            GameObject clone = (GameObject)Instantiate(explode, pos, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Destroy(clone, 0.05f);
        }
    }
}
