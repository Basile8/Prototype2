using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10f;
    public float xRange = 25;
    public GameObject projectilePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);

        //Conditions si le personnage dépasse les limites du terrain
        if(transform.position.x > xRange){
           transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x < - xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(projectilePrefabs,transform.position, projectilePrefabs.transform.rotation);
        }

    }
}
