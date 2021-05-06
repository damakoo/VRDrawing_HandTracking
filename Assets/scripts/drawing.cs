using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawing : MonoBehaviour
{

    [SerializeField] GameObject LineObjectPrefab_magenta;
    [SerializeField] GameObject LineObjectPrefab_red;
    [SerializeField] GameObject LineObjectPrefab_blue;
    [SerializeField] GameObject LineObjectPrefab_black;
    [SerializeField] GameObject LineObjectPrefab_yellow;
    [SerializeField] GameObject LineObjectPrefab_white;
    [SerializeField] GameObject LineObjectPrefab_green;
    [SerializeField] Transform HandAnchor;
    [SerializeField] colorchange _colorchange;
    [SerializeField] collisioncheck _collisioncheck;

    [SerializeField] OVRHand _OVRHand_Right;
    [SerializeField] OVRHand _OVRHand_Left;

    [SerializeField] modechange _modechange;
    [SerializeField] dimentionchange _dimentionchange;
    [SerializeField] Transform _pinkpenpos;
    [SerializeField] sizechange _sizechange;

    [SerializeField] Transform table;
    [SerializeField] Transform Blackboard;

    private GameObject CurrentLineObject = null;
    public bool grabbing = false;

    private Transform Pointer
    {
        get
        {
            return HandAnchor;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_modechange.drawmode == 1 && _dimentionchange.drawdimention == 0)
        {
            var pointer = Pointer;
            if (pointer == null)
            {
                return;
            }

            if (/*_OVRHand_Right.GetFingerPinchStrength(OVRHand.HandFinger.Middle) >= 0.1f && */_OVRHand_Right.GetFingerPinchStrength(OVRHand.HandFinger.Index) >= 0.8f)// && _OVRHand_Right.GetFingerPinchStrength(OVRHand.HandFinger.Thumb) >= 0.30f)
            {
                if (CurrentLineObject == null)
                {
                    if (_colorchange._colornumber == 0)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_magenta, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 1)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_red, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 2)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_blue, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 3)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_black, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 4)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_yellow, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 5)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_white, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 6)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_green, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                }
                LineRenderer render = CurrentLineObject.GetComponent<LineRenderer>();

                int NextPositionIndex = render.positionCount;
                render.positionCount = NextPositionIndex + 1;
                render.SetPosition(NextPositionIndex, pointer.position - 0.12f * pointer.up - 0.11f * pointer.right - 0.03f * pointer.forward);

                SphereCollider cc = CurrentLineObject.AddComponent<SphereCollider>() as SphereCollider;
                cc.center = pointer.position - 0.12f * pointer.up - 0.11f * pointer.right - 0.03f * pointer.forward;
                cc.isTrigger = true;
                cc.radius = _sizechange.fontsize;

            }
            else
            {
                if (CurrentLineObject != null)
                {
                    CurrentLineObject = null;
                }
            }
        }
        else if (_modechange.drawmode == 2)
        {
            if (_OVRHand_Right.GetFingerPinchStrength(OVRHand.HandFinger.Index) >= 0.8f && _OVRHand_Right.GetFingerPinchStrength(OVRHand.HandFinger.Thumb) >= 0.8f)
            {
                if (!grabbing)
                {
                    grabbing = true;
                }
            }
            else if (grabbing)
            {
                grabbing = false;
            }
        }
        else if(_modechange.drawmode == 1 && _dimentionchange.drawdimention == 1)
        {
            var pointer = Pointer;
            if (pointer == null)
            {
                return;
            }

            if (_collisioncheck.collisionjudgement != 0)
            {
                if (CurrentLineObject == null)
                {
                    if (_colorchange._colornumber == 0)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_magenta, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 1)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_red, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 2)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_blue, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 3)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_black, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 4)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_yellow, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 5)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_white, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                    else if (_colorchange._colornumber == 6)
                    {
                        CurrentLineObject = Instantiate(LineObjectPrefab_green, new Vector3(0, 0, 0), Quaternion.identity);
                        CurrentLineObject.GetComponent<LineRenderer>().startWidth = _sizechange.fontsize;
                        CurrentLineObject.GetComponent<LineRenderer>().endWidth = _sizechange.fontsize;
                    }
                }
                LineRenderer render = CurrentLineObject.GetComponent<LineRenderer>();

                int NextPositionIndex = render.positionCount;
                render.positionCount = NextPositionIndex + 1;
               // render.SetPosition(NextPositionIndex,new Vector3 (_collisioncheck.collisionpos.x, _collisioncheck.collisionpos.y,Blackboard.position.z));
                Vector3 writepos = pointer.position - 0.12f * pointer.up - 0.11f * pointer.right - 0.03f * pointer.forward;
                //render.SetPosition(NextPositionIndex, new Vector3(writepos.x,writepos.y, Blackboard.position.z));
                //render.SetPosition(NextPositionIndex, pointer.position - 0.12f * pointer.up - 0.11f * pointer.right - 0.03f * pointer.forward);


                SphereCollider cc = CurrentLineObject.AddComponent<SphereCollider>() as SphereCollider;
                //cc.center = new Vector3(_collisioncheck.collisionpos.x, _collisioncheck.collisionpos.y, Blackboard.position.z);
                //cc.center = new Vector3(writepos.x, writepos.y, Blackboard.position.z);
                //cc.center = pointer.position - 0.12f * pointer.up - 0.11f * pointer.right - 0.03f * pointer.forward;


                if (_collisioncheck.collisionjudgement == 1)
                {
                    render.SetPosition(NextPositionIndex, new Vector3(_collisioncheck.collisionpos.x, _collisioncheck.collisionpos.y, Blackboard.position.z));
                    cc.center = new Vector3(_collisioncheck.collisionpos.x, _collisioncheck.collisionpos.y, Blackboard.position.z);
                }
                else if (_collisioncheck.collisionjudgement == 2)
                {
                    render.SetPosition(NextPositionIndex, new Vector3(_collisioncheck.collisionpos.x, table.position.y + 0.35f, _collisioncheck.collisionpos.z));
                    cc.center = new Vector3(_collisioncheck.collisionpos.x, table.position.y + 0.35f, _collisioncheck.collisionpos.z);
                }

                cc.isTrigger = true;
                cc.radius = _sizechange.fontsize;
            }
            else
            {
                if (CurrentLineObject != null)
                {
                    CurrentLineObject = null;
                }
            }
        }
    }
}
