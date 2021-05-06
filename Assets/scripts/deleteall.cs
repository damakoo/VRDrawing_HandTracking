using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class deleteall : MonoBehaviour
{
    private bool pressed = false;
    public bool _delete = false;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed)
            {
                pressed = true;
                _delete = true;
                Invoke("resetpress", 0.5f);

            }
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
    void resetpress()
    {
        pressed = false;
        _delete = false;
    }
}
