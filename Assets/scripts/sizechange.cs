using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.UI;

public class sizechange : MonoBehaviour
{
    private bool pressed_plus = false;
    private bool pressed_minus = false;
    public float fontsize = 0.01f;
    [SerializeField] GameObject _minusbutton;
    [SerializeField] Text _text;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed_plus)
            {
                pressed_plus = true;
                fontsize += 0.001f;
                _text.text = (Mathf.Round(fontsize * 1000)/10).ToString("f1");
                Invoke("resetpress_plus", 0.5f);

            }
        };


        _minusbutton.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed_minus)
            {
                pressed_minus = true;
                if (fontsize > 0.001f)
                {
                    fontsize -= 0.001f;
                }
                _text.text = (Mathf.Round(fontsize * 1000) / 10).ToString("f1");
                Invoke("resetpress_minus", 0.5f);

            }
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
    void resetpress_plus()
    {
        pressed_plus = false;
    }
    void resetpress_minus()
    {
        pressed_minus = false;
    }
}
