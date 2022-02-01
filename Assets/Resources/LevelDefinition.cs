using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Level", menuName = "Level")]
public class LevelDefinition : ScriptableObject
{
    public List<WaveDefintion> waves;
    public float spawnInterval;
}
