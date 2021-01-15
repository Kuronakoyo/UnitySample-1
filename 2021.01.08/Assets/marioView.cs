using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class marioView : MonoBehaviour
{
    // marioの状態
       public enum UnitMode
    {
        Stand = 0, //立ち止まり
        Walk //移動
    }
    //入れ替え用のイメージ
    [SerializeField]
    private List<Sprite> marioImage = new List<Sprite>();
    //立ち止まりようの変数
    #region
    //立ち止まった直後からアニメーションまでの待機時間
    private float standingInitTimeMax = 3;
    //立ち留まり中のアニメーションの待機時間
    private float standingChangeTimeMax = 1;
    //立ち留まった直後がどうかのフラグ
    private bool isStopInit = true;
    #endregion


    #region 
    //移動パターン番号
    private int walkActionNum = 0;
    //移動パターンテーブル
    private int[] walkTable = { 2, 1, 3 };
    //アニメーション切り替えフレーム数
    private float walkFrameMax = 6;
    #endregion
    //タイマー（時間とフレームを用意）
    private float timer = 0;
    private float frames = 0;
    public const int DirectionLeft = -1;
    public const int DirectionRight = 1;
    //現在のキャラクターのモード
    private UnitMode unitmode = UnitMode.Stand;
    public UnitMode UMode 
    { 
        set
        {
            unitmode = value;
            if (UnitMode.Stand == unitmode)
                InitStand();
            else if (UnitMode.Walk == unitmode)
                InitWalk();
        }
        get
        {
            return UMode;
        }
    }
    //キャラクターの向き
    private int direction = 1;
    public int Direction { set { direction = value; SetDrection(); } }


    // Update is called once per frame
    void Update()
    {
        if (UnitMode.Stand == unitmode)
            StandAnimation();
        else if(UnitMode.Walk == unitmode)
            WalkAnimation();
    }
    private void InitStand()
    {
        //立ち留まりイメージをセットする
        GetComponent<Image>().sprite = marioImage[0];
        //タイマーを初期化
        timer = 0;
        //立ち留まり初期化フラグをセットする
        isStopInit = true;
    }
    /// <summary>
     /// 立ち留まりアニメーション
     /// </summary>
    private void StandAnimation()
    {
        //時間の経過を足す
        timer += Time.deltaTime;
        //立ち留まった直後
        if(isStopInit)
        {
            //アニメーションの時間になったかどうかの判断
            if (standingInitTimeMax <= timer)
            {
                //一度きりのフラグなのでクリアしておく
                isStopInit = false;
                //時間をクリアする
                timer = 0;
                //立ち留まりイメージをセットする
                GetComponent<Image>().sprite = marioImage[0];
                //キャラクターの向きを反転させる
                direction *= -1;
                GetComponent<RectTransform>().localScale = new Vector2(direction, 1);
            }
        }
        else
        {
            if(standingChangeTimeMax <= timer)
            {
                //時間をクリアする
                timer = 0;
                //キャラクターの向きを反転させる
                direction *= -1;
                GetComponent<RectTransform>().localScale = new Vector2(direction, 1);
            }
        }
    }
    /// <summary>
    /// 移動の初期化
    /// </summary>
    private void InitWalk()
    {
        //フレームを初期化
        frames = 0;
        //アニメーションの数値を初期化
        walkActionNum = 0;
        //最初の画像をセット
        GetComponent<Image>().sprite = marioImage[walkTable[walkActionNum]];
        //キャラクターの向きを反転させる
        GetComponent<RectTransform>().localScale = new Vector2(direction, 1);
    }
    



    /// <summary>
    /// 移動アニメーション
    /// </summary>
    private void WalkAnimation()
    {
        //フレームを加算
        frames++;
        //所定のフレームに達したら画像の入れ替え
        if(walkFrameMax <=frames)
        {
            //フレームを初期化
            frames = 0;
            //アニメーションパターンのカウントを進ませる
            walkActionNum++;
            //テーブルを超えないように調整
            walkActionNum %= walkTable.Length;
            //入れ替え画像をセット
            GetComponent<Image>().sprite = marioImage[walkTable[walkActionNum]];
        }
    }

    private void SetDrection()
    {
        GetComponent<RectTransform>().localScale = new Vector2(direction, 1);
    }
}  
