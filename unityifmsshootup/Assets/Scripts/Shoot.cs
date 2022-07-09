using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject explode;
    public string alvo;
    ScoreManager score;

    public void Awake()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.name.StartsWith(alvo))
        {
            Vector3 pos = collider2D.transform.position;
            GameObject clone = (GameObject)Instantiate(explode, pos, Quaternion.identity);
            Score.Pontuar();
            Destroy(collider2D.gameObject);
            Destroy(this.gameObject);
            Destroy(clone, 0.05f);
        }
    }
}
