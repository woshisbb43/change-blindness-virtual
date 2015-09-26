using UnityEngine;
using System.Collections;

public class BlaBla : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    private int frameNum;
    public Color colorB = new Color(0, 0, 1, 1);
    public Color colorY = new Color(1, 0, 0, 1);
    Vector3 movement = new Vector3(10, 0, 0);
    private bool firsttime = true;
    private int maxframe = 150;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        frameNum = 0;
    }

    //FixedUpdate should be used instead of Update when dealing with Rigidbody
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        if (firsttime)
        {
            if (frameNum < maxframe)
            {
                frameNum++;
                rb.AddForce(movement * speed * Time.deltaTime);
            }
            else
            {
                firsttime = false;
                movement.x = -movement.x;
                frameNum = 0;
            }
        }
        else
        {
            if (frameNum < maxframe*2)
            {
                frameNum++;
                rb.AddForce(movement * speed * Time.deltaTime);
            }
            else
            {
                movement.x = -movement.x;
                frameNum = 0;
            }
        }
        
    }
}
