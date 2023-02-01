using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button_score : MonoBehaviour
{
   
    Vector3 position;
    [SerializeField] Score score;
    
 
 
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void Pressed()
    {
        score.Count();
        position = new Vector3(Random.Range(5.5f, -5.5f), Random.Range(3, -3),0);
        gameObject.SetActive(false);
        gameObject.transform.position = position;
        gameObject.SetActive(true);
    }
}
