using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private Placable towerPlaceholderPrefab;
    [SerializeField] private Transform waypointsHolder;
    public List<Transform> Waypoints { get; private set; }

    private Placable buildingToPlace;
    private Camera mainCamera;

    private Dictionary<string, UnitBehaviour> enemyPrefabs = new Dictionary<string, UnitBehaviour>();

    private WaitForSeconds waitForSeconds;
    void Awake()
    {
        App.levelManager = this;
        mainCamera = Camera.main;
        GetEnemyPrefabs();
        PopulateWaypoints();
    }
    private void PopulateWaypoints()
    {
        Waypoints = new List<Transform>();
        foreach (Transform waypoint in waypointsHolder)
        {
            Waypoints.Add(waypoint);
        }
    }
    public void Init()
    {
        CreateLevel();
    }
    private void GetEnemyPrefabs()
    {
        UnitBehaviour[] prefabs = Resources.LoadAll<UnitBehaviour>("Prefabs");
        foreach (var prefab in prefabs)
        {
            enemyPrefabs.Add(prefab.name, prefab);
        }
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
    public void CreateLevel()
    {
        //TODO: level prepartion
        waitForSeconds = new WaitForSeconds(App.definitions.levels[0].spawnInterval);
    }
    public void CreateWave()
    {
        WaveDefintion currentWave = App.definitions.levels[0].waves[0]; //TODO: make a proper level & wave loader
        EnemyFactory enemyFactory = new EnemyFactory();
        StartCoroutine(WaveCoroutine(currentWave, enemyFactory));
    }
    public IEnumerator WaveCoroutine(WaveDefintion wave, EnemyFactory factory)
    {
        for (int i = 0; i < wave.count; i++)
        {
            yield return waitForSeconds;
            UnitBaseModel model = factory.Factory(wave.enemy);
            //TODO: list?
            UnitBehaviour instance = Instantiate(enemyPrefabs[wave.enemy.ToString()], Vector3.zero, Quaternion.identity); //TODO: random pos, pre-defined pos
            instance.Init(model);
            instance.name = "Enemy " + i;
        }
        yield break;
    }
}
