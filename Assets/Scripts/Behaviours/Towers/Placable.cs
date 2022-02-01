using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placable : MonoBehaviour
{
    private Vector3 newPos;

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }
    public void Move(Vector3 pos)
    {
        newPos = pos;
    }
    public void Place()
    {
        StopCoroutine(MoveCoroutine());
    }
    private IEnumerator MoveCoroutine()
    {
        while (true)
        {
            var pos = Vector3.Lerp(transform.position, new Vector3(Mathf.Round(newPos.x), transform.position.y, Mathf.Round(newPos.z)), App.gridManager.PlacableLerpSpeed * Time.deltaTime);
            pos.x = Mathf.Clamp(pos.x, 0, App.gridManager.Tiles.GetLength(0) - 1);
            pos.z = Mathf.Clamp(pos.z, 0, App.gridManager.Tiles.GetLength(1) - 1);
            transform.position = pos;
            yield return new WaitForEndOfFrame();
        }
    }
}
