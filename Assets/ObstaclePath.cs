using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePath : MonoBehaviour
{
    [SerializeField]
    private Transform startPoint;

    [SerializeField]
    private Transform endPoint;

    [SerializeField]
    private GameObject obstacle;

    void Start(){
        StartCoroutine(moveTowardsEndPoint());
    }

    private IEnumerator moveTowardsEndPoint(){
        obstacle.transform.position = startPoint.position;
        obstacle.SetActive(true);
        
        while(obstacle.transform.position != endPoint.position){
            obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, endPoint.position, 0.1f);
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(1f);
        
        obstacle.transform.position = startPoint.position;
        obstacle.SetActive(false);
        StartCoroutine(moveTowardsEndPoint());
    }
}
