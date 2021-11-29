using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public static int count;
    public Text countText;
    public Text winText;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag.Equals("Coin"))
        {
            Data.count += 1;
            Destroy(collision.gameObject);
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
   
}
