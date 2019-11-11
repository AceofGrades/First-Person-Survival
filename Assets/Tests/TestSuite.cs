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
    // Checks to see if the enemy exists in the scene
    public IEnumerator EnemyExistsInScene()
    {
        // Checks if the enmy spawns in the scene
        enemySpawner.Spawn();
        // Waits until the end of the frame
        yield return new WaitForEndOfFrame();
        Enemy enemy = Object.FindObjectOfType<Enemy>();
        Assert.IsNotNull(enemy);
    } 

    //2 
    [UnityTest]
    // Checks to see if the player exists in the scene
    public IEnumerator PlayerExistsInScene()
    {
        Player player = game.GetComponentInChildren<Player>();
        yield return null;
        Assert.IsNotNull(player);
    }

    //3
    [UnityTest]
    // Checks to see if the flashlight turns on & off 
    public IEnumerator FlashlightGetTurnedOnAndOff()
    {
        Player player = game.GetComponentInChildren<Player>();
        Flashlight flashlight = game.GetComponentInChildren<Flashlight>();
        
        yield return null;
    }
    //4
    //[UnityTest]
    //public IEnumerator GravityIsAThing()
    //{
    //    GameObject playerPrefab = Resources.Load<GameObject>("Prefabs/Player");
    //   GameObject clone = Object.Instantiate(playerPrefab);
    //    Vector3 testpos = new Vector3(0, 1, 0);
    //    clone.transform.position =testpos;
    //    float prevpos = clone.transform.position.y;
    //    yield return new WaitForEndOfFrame();
    //    yield return new WaitForFixedUpdate();
    //     float newpos = clone.transform.position.y;
    //   Assert.IsTrue(newpos > prevpos);
    //}
    [TearDown]
    public void TearDown()
    {
        Object.Destroy(game.gameObject);
    }
}