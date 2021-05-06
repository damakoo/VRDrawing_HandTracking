using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createcollider : MonoBehaviour
{
    private float _time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        if(_time > 4)
        {
            _time = 0; SphereCollider cc = this.gameObject.AddComponent<SphereCollider>() as SphereCollider;
            cc.center = new Vector3(Random.Range(1f, 2f), Random.Range(1f, 2f), Random.Range(1f, 2f));
            cc.isTrigger = true;
            cc.radius = 0.01f;
        }
    }
}
