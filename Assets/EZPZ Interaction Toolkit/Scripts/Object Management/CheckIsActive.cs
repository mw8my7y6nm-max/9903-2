//CheckIsActive -
//Event rig for checking if the subject object is active or not.
//by Matt Cabanag, Created On: Don't remember when!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckIsActive : MonoBehaviour
{
    public GameObject checkItem;
    public bool skipCheck;
    public UnityEvent onCheckTrue;
    public UnityEvent onCheckFalse;

    public void DoCheck()
    {
        if (skipCheck || checkItem.activeSelf)
            onCheckTrue.Invoke();
        else
            onCheckFalse.Invoke();
    }
}
