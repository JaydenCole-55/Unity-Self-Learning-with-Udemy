using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstructions()
    {
        Debug.Log("Here are the instructions to my game");
        Debug.Log("Player moves using 'WASD' or arrow keys");
        Debug.Log("Don't hit the walls too hard - you may go through!");
    }


    void MovePlayer()
    {
        float delX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float delZ = Input.GetAxis("Vertical")   * Time.deltaTime * moveSpeed;
        transform.Translate(delX, 0, delZ);
    }
}
