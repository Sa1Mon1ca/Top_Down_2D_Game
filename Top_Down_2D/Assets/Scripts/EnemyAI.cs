using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private enum State
    {
        Roaming
    }
    
    private State state;
    private EnemyPathFinding enemypathfinding;

    private void Awake()
    {
        enemyPathfinding = GetComponent<EnemyPathFinding>();
        state = State.Roaming;
    }

    private void Start()
    {
        StartCoroutine(RomingRoutine());
    }
    Private IEnumerator RoamingRoutine()
    {

    }
}
