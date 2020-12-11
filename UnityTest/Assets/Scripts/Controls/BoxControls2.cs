using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControls2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // オブジェクトについている RectTransform コンポーネントを所得する
        var rectTransform = GetComponent<RectTransform>();

        // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
        var pos = rectTransform.localPosition;

        // x 座標を-400に動かす
        pos.x = -400;
        // y 座標を-400に動かす
        pos.y = -400;

        // 変更した座標をオブジェクトの座標として設定する
        rectTransform.localPosition = pos;


        // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
        var scale = rectTransform.localPosition;

        // x座標を右に10動かす
        scale.x = 2.0f;
        scale.y = 2.0f;

        // 変更した座標をオブジェクトの座標として設定する
        rectTransform.localPosition = scale;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
