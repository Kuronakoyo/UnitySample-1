using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControls1 : MonoBehaviour
{
    //座標xy400にする
    void Start()
    {
        // オブジェクトについている RectTransform コンポーネントを所得する
        var rectTransform = GetComponent<RectTransform>();

        // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
        var pos = rectTransform.localPosition;

        // x座標を左に10動かす
        pos.x = pos.x + 400;

        pos.y = pos.y + 400;

        // 変更した座標をオブジェクトの座標として設定する
        rectTransform.localPosition = pos;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
