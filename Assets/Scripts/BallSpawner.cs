using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private BouncingBall m_bouncingBallPrefab;
    [SerializeField] private Vector3 m_spawnPoint;

    private int m_ballsToSpawn = 50;


    private void Start()
    {
        for (int i = 1; i <= m_ballsToSpawn; i++)
        {
            m_spawnPoint.y = Random.Range(8, 16);
            BouncingBall newBall = Instantiate(m_bouncingBallPrefab, m_spawnPoint, Quaternion.identity);
            newBall.Setup(i);
            m_spawnPoint.x += 3;
        }
    }
}
