using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vel = 1.0f;
    Vector3 direction;
    bool inMove = false;


    public void Move(Orientation orientation)
    {
        switch (orientation)
        {
            case Orientation.Up:

                direction = new Vector3(0, vel, 0);
                

                break;

            case Orientation.Down:

                direction = new Vector3(0, -vel, 0);

                break;

            case Orientation.Left:

                direction = new Vector3(-vel, 0, 0);

                break;

            case Orientation.Rigth:

                direction = new Vector3(vel, 0, 0);

                break;
        }

        if (!inMove)
        {
            StartCoroutine(FadeIn(direction));
        }
    }

    IEnumerator FadeIn(Vector3 nextPosition)
    {
            inMove = true;

            float progress = 0;
            Vector3 newPositon = transform.position + nextPosition;
            Vector3 initialPosition = transform.position;

            while (progress <= 1)
            {
                transform.position = Vector3.Lerp(initialPosition, newPositon, progress);
                progress += Time.deltaTime * 3;
                yield return null;
            }

            transform.position = newPositon;
            inMove = false;
    }
}
