using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GameSystem : MonoBehaviour
{
    public StageOut stageout;
    public Deviceinput deviceinput;
    public GameObject StageOut;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            stageout.Score = stageout.Score - 1;
        }

        if (deviceinput.wasPressedThisFram)
        {
            stageout.Score = stageout.Score - 1;
        }

        StageOut sender = StageOut.GetComponent<StageOut>();
        if (sender != null)
        {
            int StageScore = sender.Score;
            StageOut Other = GetComponent<StageOut>();
            Debug.Log($"受け取ったスコア:{StageScore}");

            stageout.scoreText.text = $"スコア:{StageScore}";
        }
        Debug.Log(stageout.Score);
        Debug.Log(deviceinput.wasPressedThisFram);
    }
}
