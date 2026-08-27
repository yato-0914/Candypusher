using UnityEngine;

public class Pusher : MonoBehaviour
{
    // アクセス修飾子
    public float speed = 1f;
    public float movePower = 5f; // 変わらず一定で使用する（振幅の基準）
    private Vector3 startPosition;

    // 範囲制限設定
    public bool useLimits = true;
    // true: startPosition を基準とした相対オフセットで制限する
    // false: ワールド座標の Z で絶対的に制限する
    public bool useRelativeLimits = true;

    // 相対オフセット（startPosition.z を基準）
    // 正方向（前）と負方向（後）で別々に上限を指定（正は +、後は magnitude）
    public float maxForwardOffset = 5f;   // startPosition.z + maxForwardOffset を超えない
    public float maxBackwardOffset = 3f;  // startPosition.z - maxBackwardOffset を超えない

    // 絶対座標による制限（ワールド Z）
    public float absoluteMaxZ = 10f; // 前方向の最大 Z
    public float absoluteMinZ = -10f; // 後方向の最小 Z

    void Start()
    {
        startPosition = this.transform.position;
        Debug.Log("ゲームが開始した");
    }

    void Update()
    {
        // -1 .. 1 の正弦波
        float sin = Mathf.Sin(Time.time * speed);
        // movePower は一定で使い、まず基準オフセットを計算（対称な基準値）
        float zOffset = sin * movePower;

        float targetZ = startPosition.z + zOffset;

        if (useLimits)
        {
            if (useRelativeLimits)
            {
                // 前方向（sin > 0）は maxForwardOffset、後方向（sin < 0）は -maxBackwardOffset で制限
                if (zOffset > 0f)
                {
                    float clamped = Mathf.Min(zOffset, maxForwardOffset);
                    targetZ = startPosition.z + clamped;
                }
                else
                {
                    float clamped = Mathf.Max(zOffset, -maxBackwardOffset);
                    targetZ = startPosition.z + clamped;
                }
            }
            else
            {
                // 絶対座標での個別制限
                targetZ = Mathf.Clamp(targetZ, absoluteMinZ, absoluteMaxZ);
            }
        }

        // X,Y は開始時の位置を保持して Z のみ変更する
        this.transform.position = new Vector3(startPosition.x, startPosition.y, targetZ);
    }
}
