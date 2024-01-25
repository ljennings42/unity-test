using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveX;
    [SerializeField] float moveY;
    [SerializeField] float moveZ;

    // Update is called once per frame
    void Update()
    {
        transform.Position(moveX * Time.deltaTime, moveY * Time.deltaTime, moveZ * Time.deltaTime);
       // transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }
}
