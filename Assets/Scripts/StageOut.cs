using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    //アクセス修飾子 型と変数
    private int Score;
    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
    void OnTriggerEnter(Collider other )
    {
        Score = Score + 1;
        Debug.Log($"スコア:{Score}");

        //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けたに呼ばれる
        //ebug.Log($"{other.name}がすりぬけた");
        // すり抜けたオブジェクトを破棄
        Destroy(other.gameObject);

    }
}