using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.UI;

public class dimentionchange : MonoBehaviour
{
    private bool pressed = false;
    public int drawdimention = 0;
    [SerializeField] Text _dimention;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed)
            {
                pressed = true;
                if (drawdimention == 0)
                {
                    drawdimention = 1;
                    _dimention.text = "2D";
                }
                else if (drawdimention == 1)
                {
                    drawdimention = 0;
                    _dimention.text = "3D";
                }


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
    }
}
