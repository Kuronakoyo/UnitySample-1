using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{
    [SerializeField]
    private float fadeInTimer = 0.1f;

    [SerializeField]
    private float fadeOutTimer = 0.3f;

    [SerializeField]
    private CanvasGroup onceCanvasGroup = null;

    public void FadeInFlame()
    {
        // 透明度を０にする
        onceCanvasGroup.alpha = 0;
        // キャンバスグループコンポーネントを所得
        StartCoroutine(FadeIn());

    }

    public IEnumerator FadeIn()
    {

        while (onceCanvasGroup.alpha < 1.0f)
        {
            onceCanvasGroup.alpha += (1.0f / fadeInTimer) * Time.deltaTime;

            if (onceCanvasGroup.alpha >= 1.0f)
                onceCanvasGroup.alpha = 1.0f;

            yield return null;
        }
    }


    public void FeadOutText(float delayTyme = 0.0f, System.Action<GameObject> cb = null)
    {
        //不透明に設定する
        onceCanvasGroup.alpha = 1.0f;
        //　フェードアウト開始
        StartCoroutine(FadeOut(delayTyme));
    }

    private IEnumerator FadeOut(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        //オブジェクトの透明度が０（透明）になるまで処理を行う
        while (onceCanvasGroup.alpha > 0.0f)
        {
            onceCanvasGroup.alpha -= (1.0f / fadeOutTimer) * Time.deltaTime;

            if (onceCanvasGroup.alpha <= 0.0f)
                onceCanvasGroup.alpha = 0.0f;

            yield return null;
        }

    }
}
