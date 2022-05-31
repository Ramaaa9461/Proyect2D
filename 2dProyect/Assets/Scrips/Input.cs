
using UnityEngine;
using UnityEngine.Events;

public class Input : MonoBehaviour
{
    public EnumEvent enumEvent;
    public UnityEvent bombEvent;

    [SerializeField] KeyCode Up;
    [SerializeField] KeyCode Down;
    [SerializeField] KeyCode Left;
    [SerializeField] KeyCode Rigth;
    [SerializeField] KeyCode Bomb;

    void Update()
    {
        GetInput();
        GetInputBomb();
    }

    private void GetInput()
    {
       
        if (UnityEngine.Input.GetKey(Up))
        {
            enumEvent.Invoke(Orientation.Up);
        }
        
        if (UnityEngine.Input.GetKey(Down))
        {
            enumEvent.Invoke(Orientation.Down);
        }

        if (UnityEngine.Input.GetKey(Left))
        {
            enumEvent.Invoke(Orientation.Left);
        }

        if (UnityEngine.Input.GetKey(Rigth))
        {
            enumEvent.Invoke(Orientation.Rigth);

        }

    }

    private void GetInputBomb()
    {
        if (UnityEngine.Input.GetKeyDown(Bomb))
        {
            bombEvent.Invoke();
        }
    }
}
