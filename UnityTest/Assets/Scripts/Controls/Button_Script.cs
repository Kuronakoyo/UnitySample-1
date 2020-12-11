using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    [SerializeField]
    private Text[] _text;

    /*[SerializeField]
    private Text _text1;

    [SerializeField]
    private Text _text2;

    [SerializeField]
    private Text _text3;

    [SerializeField]
    private Text _text4;*/

    public void OnButtonChangeString()
    {
        _text[0].text = "書き換え";
        _text[1].text = "書き換えました";
        _text[2].text = "書き換え成功";
        _text[3].text = "なす";
        _text[4].text = "高原";

        _text[0].color = new Color(1.0f, 0.0f, 1.0f);
        _text[1].color = new Color(0.0f, 1.0f, 1.0f);
        _text[2].color = new Color(1.0f, 1.0f, 0.0f);
        _text[3].color = new Color(1.0f, 0.0f, 0.0f);
        _text[4].color = new Color(1.0f, 1.0f, 1.0f);
    }

}
