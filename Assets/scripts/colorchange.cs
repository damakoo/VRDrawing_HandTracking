using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.UI;

public class colorchange : MonoBehaviour
{
    [SerializeField] GameObject _pen;
    [SerializeField] Text _colortext;
    public int _colornumber = 0;
    private bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed)
            {
                pressed = true;
                if(_colornumber == 0)
                {
                    _colornumber = 1;
                    _colortext.text = "赤";
                    _colortext.color = Color.red;
                    _pen.GetComponent<Renderer>().material.color = Color.red;
                }
                else if (_colornumber == 1)
                {
                    _colornumber = 2;
                    _colortext.text = "青";
                    _colortext.color = Color.blue;
                    _pen.GetComponent<Renderer>().material.color = Color.blue;
                }
                else if (_colornumber == 2)
                {
                    _colornumber = 3;
                    _colortext.text = "黒";
                    _colortext.color = Color.black;
                    _pen.GetComponent<Renderer>().material.color = Color.black;
                }
                else if (_colornumber == 3)
                {
                    _colornumber = 4;
                    _colortext.text = "黄";
                    _colortext.color = Color.yellow;
                    _pen.GetComponent<Renderer>().material.color = Color.yellow;
                }
                else if (_colornumber == 4)
                {
                    _colornumber = 5;
                    _colortext.text = "白";
                    _colortext.color = Color.white;
                    _pen.GetComponent<Renderer>().material.color = Color.white;
                }
                else if (_colornumber == 5)
                {
                    _colornumber = 6;
                    _colortext.text = "緑";
                    _colortext.color = Color.green;
                    _pen.GetComponent<Renderer>().material.color = Color.green;
                }
                else if (_colornumber == 6)
                {
                    _colornumber = 0;
                    _colortext.text = "ピンク";
                    _colortext.color = Color.magenta;
                    _pen.GetComponent<Renderer>().material.color = Color.magenta;
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
