using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.UI;

public class modechange : MonoBehaviour
{
    private bool pressed = false;
    public int drawmode = 0;
    [SerializeField] Text _mode;
    [SerializeField] GameObject _pen;
    [SerializeField] GameObject _eraser;
    [SerializeField] drawing _drawing;
    // Start is called before the first frame update
    void Start()
    {
        _pen.SetActive(false);
        _eraser.SetActive(false);
        this.gameObject.GetComponent<ButtonController>().ActionZoneEvent += args =>
        {
            if (!pressed)
            {
                pressed = true;
                if(drawmode == 0)
                {
                    drawmode = 1;
                    _mode.text = "かく";
                    _pen.SetActive(true);
                    _eraser.SetActive(false);
                    _drawing.grabbing = false;
                }
                else if (drawmode == 1)
                {
                    drawmode = 2;
                    _mode.text = "けす";
                    _pen.SetActive(false);
                    _eraser.SetActive(true);
                }
                else if (drawmode == 2)
                {
                    drawmode = 0;
                    _mode.text = "なし";
                    _pen.SetActive(false);
                    _eraser.SetActive(false);
                    _drawing.grabbing = false;
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
