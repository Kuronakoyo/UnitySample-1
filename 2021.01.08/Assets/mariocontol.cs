using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mariocontol : MonoBehaviour
{
    private enum MarioMode
    {
        idle,
        Move
    }
    //左きー押し
    private const uint LeftKey = 0x01;
    //右きー押し
    private const uint RightKey = 0x02;
    //左きー押しっぱなし
    private const uint LeftKeyPressed = 0x04;
    //右きー押しっぱなし
    private const uint RightKeyPressed = 0x08;

    [SerializeField]
    private marioView mView;
    [SerializeField]
    private float walkSpeed = 8;
    //マリオの向き
    private int direction = marioView.DirectionRight;
    //現在のキー入力情報
    private uint keyInputMode = 0;
    //現在のマリオのモード
    private MarioMode marioMode = MarioMode.idle;
    // Update is called once per frame
    void Update()
    {

        InputMarioKey();
        ActionMario();
           
    }

    private void InputMarioKey()
    {
        //左矢印を押した
        if (Input.GetKeyDown(KeyCode.LeftArrow))

            keyInputMode |= LeftKey;

        //右矢印を押した
        if (Input.GetKeyDown(KeyCode.RightArrow))

            keyInputMode |= RightKey;
        //左矢印を離した
        if (Input.GetKeyUp(KeyCode.LeftArrow))

            keyInputMode &= ~LeftKey;

        //右矢印を離した
        if (Input.GetKeyUp(KeyCode.RightArrow))

            keyInputMode &= ~RightKey;
    }

    private void ActionMario()
    {

        //左と右の矢印を押していない
        if (((LeftKey | RightKey) & keyInputMode) == 0)
        {
            AllKeyOff();
        }
        else if (MarioMode.idle == marioMode)
        {
            ActionIdleInput();
        }
        else
        {
            ActionMoveInput();
        }
    }

    private void AllKeyOff()
    {
        marioMode = MarioMode.idle;
        mView.UMode = marioView.UnitMode.Stand;
    }

    private void ActionIdleInput()
    {
        // 左キーを押している
        if (0 != (LeftKey & keyInputMode))
        {
            marioMode = MarioMode.Move;
            mView.Direction = marioView.DirectionLeft;
            mView.UMode = marioView.UnitMode.Walk;
        }
        //右キーを押している
        if (0 != (RightKey & keyInputMode))
        {
            marioMode = MarioMode.Move;
            mView.Direction = marioView.DirectionRight;
            mView.UMode = marioView.UnitMode.Walk;
        }
    }

    private void ActionMoveInput()
    {
        var pos = GetComponent<RectTransform>().localPosition;

        // 左キーを押している
        if (0 != (LeftKey & keyInputMode))
        {
            mView.Direction = marioView.DirectionLeft;
            pos.x -= walkSpeed;
        }
        //右キーを押している
        else if (0 != (RightKey & keyInputMode))
        {
            mView.Direction = marioView.DirectionRight;
            pos.x += walkSpeed;
        }
        GetComponent<RectTransform>().localPosition = pos;
    }
}
