using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    [SerializeField] private Transform onCollisionParticle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 collisionPoint = collision.GetContact(0).point;
        Instantiate<Transform>(onCollisionParticle, collisionPoint, Quaternion.identity);
    }
}
