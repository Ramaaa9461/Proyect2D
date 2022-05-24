using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckCollisions : MonoBehaviour
{
    public UnityEvent<bool> checkCollision;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkCollision.Invoke(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        checkCollision.Invoke(false);
    }
}
