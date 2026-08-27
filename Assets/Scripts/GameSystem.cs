using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class GameSystem : MonoBehaviour
{
    public StageOut stageout;
    public Deviceinput deviceinput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stageout.scoreText.text = $"ÉXÉRÉA:{Score}";
      
        //Debug.Log(stageout.Score);
        //Debug.Log(deviceinput.createCandy);
    }
}
