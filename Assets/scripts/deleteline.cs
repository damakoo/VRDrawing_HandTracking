using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteline : MonoBehaviour
{
    drawing _drawing;
    deleteall _deleteall;
    private float _time = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        _drawing = GameObject.Find("GameObject").GetComponent<drawing>();
        _deleteall = GameObject.Find("deletebutton").GetComponent<deleteall>();
    }

    // Update is called once per frame
    void Update()
    {
    
        if (_deleteall._delete)
        {
            Destroy(this.gameObject);
        }   
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name =="Eraser" && _drawing.grabbing)
        {
            Destroy(this.gameObject);
        }
    }
}
