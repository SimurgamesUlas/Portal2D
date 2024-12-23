using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform newPos;
    public bool isOrange;

    void Start()
    {
        if(isOrange){
            newPos = GameObject.FindGameObjectWithTag("Blue").GetComponent<Transform>();

        }else{
             newPos = GameObject.FindGameObjectWithTag("Orange").GetComponent<Transform>();
        }
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        
        if(Vector2.Distance(transform.position,other.transform.position) > 0.3f){
            other.transform.position = new Vector2(
                newPos.position.x,
                newPos.position.y
            );
        }

    }
}
