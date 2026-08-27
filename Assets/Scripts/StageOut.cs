using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    //アクセス修飾子 型と変数
    public int Score = 0;

    public TextMeshProUGUI scoreText;
    public AudioManager audioManager;
    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
    void OnTriggerEnter(Collider other )
    {
        AudioManager.instance.SEPlay(1);

        Score = Score + 1;

        scoreText.text = $"スコア:{Score}";


        //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
        //ebug.Log($"{other.name}がすりぬけた");
        // すり抜けたオブジェクトを破棄
        Debug.Log($":{other.name}がすり抜けました。");

        Destroy(other.gameObject);

        if (Score == 10)
        {
            
            AudioManager.instance.BGMPlay();
        }
    }
}