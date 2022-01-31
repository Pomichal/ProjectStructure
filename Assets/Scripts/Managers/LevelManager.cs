using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private Placable towerPlaceholderPrefab;

    private Placable buildingToPlace;
    private Camera mainCamera;
    void Awake()
    {
        App.levelManager = this;
        mainCamera = Camera.main;
    }

    public void Init()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && buildingToPlace == null)
        {
            InstantiateTower();
        }
        if (buildingToPlace != null)
        {
            MoveTowerWithMouse();
        }
    }
    private void InstantiateTower()
    {
        buildingToPlace = Instantiate(towerPlaceholderPrefab, Vector3.zero, Quaternion.identity);
    }
    private void MoveTowerWithMouse()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                buildingToPlace.Move(new Vector3(hit.point.x, 0, hit.point.z));
            }
            // var pos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.transform.position.z));
            // buildingToPlace.transform.position = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        }
    }
}
