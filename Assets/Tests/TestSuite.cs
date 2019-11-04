using UnityEngine;
using UnityEngine.TestTools;
using System.Collections;

using NUnit.Framework;

public class TestSuite
{
    private Game game;
    private EnemyRepswan enemySpawner;

    [SetUp]
    public void Setup()
    {
        GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
        GameObject clone = Object.Instantiate(gamePrefab);
        game = clone.GetComponent<Game>();
        enemySpawner = game.GetComponentInChildren<EnemyRepswan>();
    }
    
    // 1
    [UnityTest]
    public IEnumerator EnemyExistsInScene()
    {
        enemySpawner.Spawn();
        yield return new WaitForEndOfFrame();
        Enemy enemy = Object.FindObjectOfType<Enemy>();
        Assert.IsNotNull(enemy);
    } 

    //2 
    [UnityTest]
    public IEnumerator Player()
    {
        Player player = game.GetComponentInChildren<Player>();
        yield return null;
    }

    //3
    [UnityTest]
    public IEnumerator FlashlightGetTurnedOnAndOff()
    {
        Flashlight flashlight = game.GetComponentInChildren<Flashlight>();
        yield return null;
    }
    
    [TearDown]
    public void TearDown()
    {
        Object.Destroy(game.gameObject);
    }
}