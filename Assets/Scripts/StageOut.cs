using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    //アクセス修飾子 型と変数
    private int Score = 0;

    public TextMeshProUGUI scoreText;
    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
    void OnTriggerEnter(Collider other )
    {
        Score = Score + 1;
        scoreText.text = $"スコア:{Score}";


        //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
        //ebug.Log($"{other.name}がすりぬけた");
        // すり抜けたオブジェクトを破棄
        Debug.Log($":{other.name}がすり抜けました。");

        Destroy(other.gameObject);

    }
}