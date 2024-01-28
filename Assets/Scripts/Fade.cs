using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] private Color color = new Color(0, 0, 0);
    [SerializeField] private float fadeTime = 3.0f;
    [SerializeField] private int loopCnt = 20;

    IEnumerator Color_FadeIn()
    {
        // 画面をフェードインさせるコールチン
        // 前提：画面を覆うPanelにアタッチしている

        // 色を変えるゲームオブジェクトからImageコンポーネントを取得
        Image fade = GetComponent<Image>();
        fade.enabled = true;
        // フェード元の色を設定（黒）★変更可
        fade.color = color;

        // フェードインにかかる時間（秒）★変更可
        float fade_time = fadeTime;

        // ループ回数（0はエラー）★変更可
        int loop_count = loopCnt;
        if (loop_count == 0) {  loop_count = 1; }

        // ウェイト時間算出
        float wait_time = fade_time / loop_count;

        // 色の間隔を算出
        float alpha_interval = 255.0f / loop_count;

        // 色を徐々に変えるループ
        for (float alpha = 255.0f; alpha >= 0.0f; alpha -= alpha_interval)
        {
            // 待ち時間
            yield return new WaitForSeconds(wait_time);

            // Alpha値を少しずつ下げる
            Color new_color = fade.color;
            new_color.a = alpha / 255.0f;
            fade.color = new_color;
        }
        fade.enabled = false;
    }

    IEnumerator Color_FadeOut()
    {
        
        // 画面をフェードインさせるコールチン
        // 前提：画面を覆うPanelにアタッチしている

        // 色を変えるゲームオブジェクトからImageコンポーネントを取得
        Image fade = GetComponent<Image>();
        fade.enabled = true;
        // フェード元の色を設定（黒）★変更可
        fade.color = color;

        // フェードインにかかる時間（秒）★変更可
        float fade_time = fadeTime / 2;

        // ループ回数（0はエラー）★変更可
        int loop_count = loopCnt;
        if (loop_count == 0) { loop_count = 1; }

        // ウェイト時間算出
        float wait_time = fade_time / loop_count;

        // 色の間隔を算出
        float alpha_interval = 255.0f / loop_count;

        // 色を徐々に変えるループ
        for (float alpha = 0f; alpha <= 255.0f; alpha += alpha_interval)
        {
            // 待ち時間
            yield return new WaitForSeconds(wait_time);

            // Alpha値を少しずつ下げる
            Color new_color = fade.color;
            new_color.a = alpha / 255.0f;
            fade.color = new_color;
        }
        fade.color = color;
    }

    public void FadeIn()
    {
        StartCoroutine("Color_FadeIn");
    }

    public void FadeOut()
    {
        StartCoroutine("Color_FadeOut");
    }
}
