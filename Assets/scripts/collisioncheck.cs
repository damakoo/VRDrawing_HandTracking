using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncheck : MonoBehaviour
{
    public int collisionjudgement = 0;
    public Vector3 collisionpos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BlackBoard")
        {
            collisionjudgement = 1;
        }
        else if (other.gameObject.name == "table")
        {
            collisionjudgement = 2;
        }


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "BlackBoard")
        {
            collisionpos = other.ClosestPointOnBounds(this.transform.position);
            collisionjudgement = 1;
        }
        else if (other.gameObject.name == "table")
        {
            collisionpos = other.ClosestPointOnBounds(this.transform.position);
            collisionjudgement = 2;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        collisionjudgement = 0;
    }
}