using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginScript : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")){
            Debug.Log("11111");
            Destroy(GetComponent<Rigidbody2D>());
        }
    }
}
