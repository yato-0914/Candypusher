using UnityEngine;
using UnityEngine.UIElements;

public class MovePingPong : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPos.x + x, startPos.y, startPos.z);
    }
}
