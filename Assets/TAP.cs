using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAP : MonoBehaviour
{
    public GameObject spawnobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2  offset = new Vector2 (0,5);
            Instantiate(spawnobject,pos,Quaternion.identity);
        }
        
    }
}
