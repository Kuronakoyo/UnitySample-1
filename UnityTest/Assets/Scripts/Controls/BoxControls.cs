using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControls : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 左の十字キーを押す
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rectTransform = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var pos = rectTransform.localPosition;

            // x座標を左に10動かす
            pos.x = pos.x - 10;

            // 変更した座標をオブジェクトの座標として設定する
            rectTransform.localPosition = pos;
        }

        // 右の十字キーを押す
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rectTransform = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var pos = rectTransform.localPosition;

            // x座標を右に10動かす
            pos.x = pos.x + 10;

            // 変更した座標をオブジェクトの座標として設定する
            rectTransform.localPosition = pos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rectTransform = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var scale = rectTransform.localPosition;

            // x座標を右に10動かす
            scale.x = scale.x + 0.01f;
            scale.y = scale.y - 0.01f;

            // 変更した座標をオブジェクトの座標として設定する
            rectTransform.localPosition = scale;
        }

        else if (Input.GetKey(KeyCode.D)) ;
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rectTransform = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var scale = rectTransform.localPosition;

            // x座標を右に10動かす
            scale.x = scale.x + 0.01f;
            scale.y = scale.y - 0.01f;

            // 変更した座標をオブジェクトの座標として設定する
            rectTransform.localPosition = scale;
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rect = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var rotate = rect.localPosition;

            // x座標を右に10動かす
            rotate.z +=5f;

            // 変更した座標をオブジェクトの座標として設定する
            rect.localPosition = rotate;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            // オブジェクトについている RectTransform コンポーネントを所得する
            var rect = GetComponent<RectTransform>();

            // オブジェクトの座標を所得する。(x,y,z)の値を所得する。
            var rotate = rect.localPosition;

            // x座標を右に10動かす
            rotate.z = -+ 5f;

            // 変更した座標をオブジェクトの座標として設定する
            rect.localPosition = rotate;
        }
    }
}
