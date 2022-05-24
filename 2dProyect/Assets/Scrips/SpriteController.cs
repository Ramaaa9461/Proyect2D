using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] Sprite spriteUp;
    [SerializeField] Sprite spriteDown;
    [SerializeField] Sprite spriteLeft;
    [SerializeField] Sprite spriteRigth;

    bool ReceiveDamage { get; set; }

    public void SetSprite(Orientation orientation)
    {
        switch (orientation)
        {
            case Orientation.Up:

                spriteRenderer.sprite = spriteUp;
                break;

            case Orientation.Down:

                spriteRenderer.sprite = spriteDown;
                break;

            case Orientation.Left:

                spriteRenderer.sprite = spriteLeft;
                break;

            case Orientation.Rigth:

                spriteRenderer.sprite = spriteRigth;
                break;
        }

    }

    public void RecibeDamage(bool receiveDamage)
    {
        ReceiveDamage = receiveDamage;
    }

    private void Update()
    {
        if (ReceiveDamage)
        {
            spriteRenderer.color = Color.Lerp(Color.red, Color.white, Mathf.PingPong(Time.time, 1));
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

}
