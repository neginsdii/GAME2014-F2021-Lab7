using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovingPlatfromController : MonoBehaviour
{

    [Header("Movement")]
    public MovingPlatformDirection direction;
    [Range(0.1f,10.0f)]
    public float speed;
    [Range(0.1f,10.0f)]
    public float distance;
    public bool isLooping;
    [Range(0.05f,0.1f )]
    public float distanceOffset;
    private Vector2 StartingPosition;
    private bool MovingisActive;
    // Start is called before the first frame update
    void Start()
    {
        StartingPosition = transform.position;
        MovingisActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        if(isLooping)
		{
            MovingisActive = true;
		}
    }

    private void MovePlatform()
	{
        float pingPongValue = (MovingisActive) ? Mathf.PingPong(Time.time * speed, distance) : distance;
        if (!isLooping &&( pingPongValue>=distance - distanceOffset))
		{
            MovingisActive = false;
		}
        switch(direction)
		{
            case MovingPlatformDirection.HORIZONTAL:
                transform.position = new Vector2(StartingPosition.x + pingPongValue, transform.position.y);

                break;
            case MovingPlatformDirection.VERTICAL:
                transform.position = new Vector2(transform.position.x , pingPongValue+ StartingPosition.y);

                break;
            case MovingPlatformDirection.DIAGONAL_UP:
                transform.position = new Vector2(StartingPosition.x +pingPongValue, StartingPosition.y +pingPongValue);

                break;
            case MovingPlatformDirection.DIAGONAL_DOWN:
                transform.position = new Vector2(StartingPosition.x + pingPongValue, StartingPosition.y - pingPongValue);
                break;

        }
    }
}
