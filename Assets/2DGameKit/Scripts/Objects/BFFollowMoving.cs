using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFFollowMoving : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.transform.SetParent(gameObject.transform);
        Debug.Log(collision.gameObject.transform.parent + " is parent of " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
        Debug.Log(collision.gameObject.transform.parent + " is parent of " + collision.gameObject.name);
    }
}
