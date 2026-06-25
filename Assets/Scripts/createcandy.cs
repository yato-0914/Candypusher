using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class createcandy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int CandyCount = 0;
    public GameObject CandyPrefab;
    private void Start()
    {
        AddCandy();
    }
    void AddCandy()
    {
        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);
        //オブジェクトの生成方法
        //型 変数 = 初期値(Instantlateで作られたオブジェクト)
        GameObject createPrefab = Instantiate(CandyPrefab);
        // positionを自身(コードアタッチされているオブジェクト)と同じにする
        createPrefab.transform.position = this.transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        //if文 もしも（条件）がtrueならば{ }の処理をする
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
    }
}

