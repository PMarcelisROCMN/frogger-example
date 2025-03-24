using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float timeBetweenMoves = .2f;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenMoves)
        {

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 01f);
                timer = 0;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -01f);
                timer = 0;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-01f, 0, 0);
                timer = 0;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(01f, 0, 0);
                timer = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("Game Over");
        }
    }
}
