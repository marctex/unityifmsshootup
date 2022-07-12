using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;
    public int contador;
    
   public void Pontuar()
    {
        contador += 1;
        score.text = contador.ToString() + " POINTS";
    }
}
