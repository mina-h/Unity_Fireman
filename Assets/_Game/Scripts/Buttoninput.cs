using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttoninput : MonoBehaviour
{
    public bool left;
    private void OnMouseDown()
    {

        if (left)
        {
            Debug.Log("touch!");
        }
        else
        {
            Debug.Log("touch right!");
        }
    }
}
