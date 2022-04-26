using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 35.0f;
    private float bottomBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }
        if(transform.position.z <bottomBound){
            Destroy(gameObject);
            Debug.Log("Game Over !");    
        }
    }
}
