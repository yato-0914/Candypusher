using UnityEngine;
using UnityEngine.InputSystem;
public class Createcandy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int CandyCount = 0;
    public GameObject CandyPrefab;
    //GameObjectの配列を作成
    public GameObject[] CandyPrefabs;
    private Vector3 startPosition;
    public AudioManager audioManager;

     void Start()
    {
        startPosition = this.transform.position;
        AddCandy();
    }
    public void AddCandy()
    {
        AudioManager.instance.SEPlay(0);
        CandyCount = CandyCount + 1;
        Debug.Log(CandyCount);
        // 0～CandyPrefabsの要素-1までのランダムな整数を取得
        int rand = Random.Range(0,100);
        int candyType = 0;
        
        //それぞれの当選確率
        //5%の確率でcandyTypeを0
        if (rand < 50)
        {
            candyType = 0;
        }
        //もしもrandが50以上80未満ならcandyTypeを1
        else if (rand < 80)
        {
            candyType = 1;
        }
        //もしもrandが50以上99未満ならcandyTypeを2
        else if (rand < 99)
        {
            candyType = 2;
        }
            //オブジェクトの生成方法
            //型 変数 = 初期値(Instantlateで作られたオブジェクト)
             GameObject createPrefab = Instantiate(CandyPrefabs[candyType]);
        // positionを自身(コードアタッチされているオブジェクト)と同じにする
        CandyPrefab.transform.position = this.transform.position;
    }
     // Update is called once per frame
    void Update()
    {
        float x = Mathf.Sin(Time.time * 3f)*3f;
        this.transform.position = startPosition + new Vector3(x, 0, 0);
         //if文 もしも（条件）がtrueならば{ }の処理をする
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
    }
}

