using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deviceinput : MonoBehaviour
{
    public InputAction createCandyAction;
    private InputAction inputVector2Action;
    public Createcandy createCandy;

 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InputSystem‚É“o˜^‚³‚ê‚Ä‚¢‚éAction–¼"Attack"‚ðŽæ“¾‚µ‚Ä‚¢‚é
        createCandyAction = InputSystem.actions.FindAction("CreateCandy");
        inputVector2Action = InputSystem.actions.FindAction("ValueTest");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inputVector2Action.ReadValue<Vector2>());

        //‚à‚µ‚àcreateCandyAction‚É“o˜^‚³‚ê‚Ä‚¢‚éƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚ç
        if (createCandyAction.WasPressedThisFrame())
        {
            createCandy.AddCandy();
        }
        
    }
}
