using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mariocontol : MonoBehaviour
{
    [SerializeField]
    private marioView mView;
    [SerializeField]
    private float walkSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        var pos = GetComponent<RectTransform>().localPosition;
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mView.Direction = marioView.DirectionLeft;
            mView.UMode = marioView.UnitMode.Walk;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            mView.Direction = marioView.DirectionRight;
            mView.UMode = marioView.UnitMode.Walk;
        }
        //左に移動
         else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= walkSpeed;

        }
        //右に移動
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += walkSpeed;

        }
        //立ち留まり
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            mView.UMode = marioView.UnitMode.Stand;
        }
        GetComponent<RectTransform>().localPosition = pos;
     
    }
}
