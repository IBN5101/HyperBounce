using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLight : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 collisionPoint = collision.GetContact(0).point;
        Instantiate(GameAssets.Instance.touchLight, collisionPoint, Quaternion.identity);
    }
}
