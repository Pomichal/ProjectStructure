using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placable : MonoBehaviour
{
    [SerializeField] private ProjectileBehaviour projectilePrefab;
    [SerializeField] private Transform shootPosition;

    private Vector3 newPos;

    private List<Transform> enemiesInRange = new List<Transform>();

    protected WaitForSeconds waitForSeconds;

    private void Start()
    {
        StartCoroutine(MoveCoroutine());
    }
    public virtual void Init(TowerModel model)
    {

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
    private void OnTriggerEnter(Collider other)
    {
        enemiesInRange.Add(other.transform);
        if (enemiesInRange.Count <= 1)
        {
            StartCoroutine(AttackCoroutine());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        enemiesInRange.Remove(other.transform);
    }
    private IEnumerator AttackCoroutine()
    {
        while (enemiesInRange.Count > 0)
        {
            var instance = Instantiate(projectilePrefab, shootPosition);
            instance.Init(enemiesInRange[0], 3);
            yield return waitForSeconds;
        }
        yield break;
    }
}
