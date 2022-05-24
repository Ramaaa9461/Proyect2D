using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vel = 1.0f;
    bool inMove = false;

    public void Move(Orientation orientation)
    {
        switch (orientation)
        {
            case Orientation.Up:

                StartCoroutine(FadeIn(new Vector3(0, vel, 0)));
                // transform.position += Vector3.Lerp(transform.position, transform.position + new Vector3(0, vel, 0), ) // new Vector3(0, vel, 0);
                break;

            case Orientation.Down:

                // transform.position += new Vector3(0, -vel, 0);
                StartCoroutine(FadeIn(new Vector3(0, -vel, 0)));
                break;

            case Orientation.Left:

                // transform.position += new Vector3(-vel, 0, 0);
                StartCoroutine(FadeIn(new Vector3(-vel, 0, 0)));

                break;

            case Orientation.Rigth:

                // transform.position += new Vector3(vel, 0, 0);
                StartCoroutine(FadeIn(new Vector3(vel, 0, 0)));

                break;
        }
    }

    IEnumerator FadeIn(Vector3 nextPosition)
    {

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

    }
}
