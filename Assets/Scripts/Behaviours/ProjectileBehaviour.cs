using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    private Transform target;
    private float speed;
    public void Init(Transform target, float speed)
    {
        this.target = target;
        this.speed = speed;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.position) < 0.01f)
        {
            Destroy(this.gameObject);
        }
    }
}
