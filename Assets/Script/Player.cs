using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public GameManager manager;

    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if ( Input.GetKeyDown(KeyCode.Return) )
        {
            manager.PushButton(this.gameObject);
        }
    }
}
