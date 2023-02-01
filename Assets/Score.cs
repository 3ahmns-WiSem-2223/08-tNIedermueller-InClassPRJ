using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
   
    int scoreInt;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Count()
    {
        scoreInt += 1;
        gameObject.GetComponent<TextMeshProUGUI>().text = scoreInt.ToString();
    }
}
