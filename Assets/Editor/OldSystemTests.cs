//using UnityEngine;
//using UnityEditor;
//using UnityEngine.TestTools;
//using NUnit.Framework;
//using System.Collections;
//
//public class SystemTests
//{
//	
//	[UnityTest]
//	public IEnumerator S1 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S2 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		for (float i = -1.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S3 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x > 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S4 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		for (float i = -1.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x > 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S5 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S6 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		for (float i = 1.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S7 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x < 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S8 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		for (float i = 1.0f; i > -1.1f; i -= 0.1f) {
//			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x < 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S9 ()
//	{
//		int testBit = 0;
//
//		Time.timeScale = 0.0f;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i * Time.timeScale);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (pauseMenu.activeInHierarchy && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Time.timeScale = 1.0f;
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S10 ()
//	{
//		int testBit = 0;
//
//		Time.timeScale = 1.0f;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i * Time.timeScale);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
//			testBit = 1;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S11 ()
//	{
//		int testBit = 0;
//
//		int sequence = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject red = testObjects.transform.Find ("Red").gameObject;
//		red.SetActive (true);
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//		Vector3 redPos = red.transform.position;
//
//		if (sequence == 0 && playerPos.x == redPos.x && playerPos.y == redPos.y && playerPos.z + 0.5f >= redPos.z - 0.5f) {
//			testBit = 1;
//		} else {
//			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
//			testBit = 0;
//		}
//
//		yield return null;
//
//		red.SetActive (false);
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S12 ()
//	{
//		int testBit = 0;
//
//		int sequence = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject orange = testObjects.transform.Find ("Orange").gameObject;
//		orange.SetActive (true);
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//		Vector3 orangePos = orange.transform.position;
//
//		if (sequence == 1 && playerPos.x == orangePos.x && playerPos.y == orangePos.y && playerPos.z + 0.5f >= orangePos.z - 0.5f) {
//			testBit = 0;
//		} else {
//			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
//			testBit = 1;
//		}
//
//		yield return null;
//
//		orange.SetActive (false);
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S13 ()
//	{
//		int testBit = 0;
//
//		int sequence = 6;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject violet = testObjects.transform.Find ("Violet").gameObject;
//		violet.SetActive (true);
//
//		GameObject winningMessage = testObjects.transform.Find ("WinningMessage").gameObject;
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//		Vector3 violetPos = violet.transform.position;
//
//		if (winningMessage.activeInHierarchy && sequence == 6 && playerPos.x == violetPos.x && playerPos.y == violetPos.y && playerPos.z + 0.5f >= violetPos.z - 0.5f) {
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		violet.SetActive (false);
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S14 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject collectible = testObjects.transform.Find ("Collectible").gameObject;
//		collectible.SetActive (true);
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//		Vector3 collectiblePos = collectible.transform.position;
//
//		if (playerPos.x == collectiblePos.x && playerPos.y == collectiblePos.y && playerPos.z + 0.6f >= collectiblePos.z - 0.6f) {
//			PlayerController playerController = GameObject.Find ("Player").GetComponent<PlayerController> ();
//			playerController.speed = 15;
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		collectible.SetActive (false);
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S15 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject collectible = testObjects.transform.Find ("Collectible").gameObject;
//		collectible.SetActive (true);
//
//		GameObject shield = testObjects.transform.Find ("Shield").gameObject;
//
//		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//		Vector3 collectiblePos = collectible.transform.position;
//
//		if (shield.activeInHierarchy && playerPos.x == collectiblePos.x && playerPos.y == collectiblePos.y && playerPos.z + 0.6f >= collectiblePos.z - 0.6f) {
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		collectible.SetActive (false);
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S16 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		for (float i = 0.0f; i < 9.5f; i += 0.1f) {
//			player.transform.position = new Vector3 (0.0f, 0.5f, i);
//		}
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 9.5f) {
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S17 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		PlayerController playerController = GameObject.Find ("Player").GetComponent<PlayerController> ();
//		playerController.Jump ();
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.y > 0.5f) {
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S18 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		player.transform.position = new Vector3 (0.0f, 1.0f, 0.0f);
//
//		PlayerController playerController = GameObject.Find ("Player").GetComponent<PlayerController> ();
//		playerController.Jump ();
//
//		Vector3 playerPos = player.transform.position;
//
//		if (playerPos.y > 0.5f) {
//			testBit = 1;
//		} else {
//			testBit = 0;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]
//	public IEnumerator S19 ()
//	{
//		int testBit = 0;
//
//		GameObject player = GameObject.FindGameObjectWithTag ("Player");
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject collectible = testObjects.transform.Find ("Collectible").gameObject;
//		GameObject red = testObjects.transform.Find ("Red").gameObject;
//		GameObject orange = testObjects.transform.Find ("Orange").gameObject;
//		GameObject violet = testObjects.transform.Find ("Violet").gameObject;
//		collectible.SetActive (true);
//		red.SetActive (true);
//		orange.SetActive (true);
//		violet.SetActive (true);
//
//		if (player.activeInHierarchy && collectible.activeInHierarchy && red.activeInHierarchy && orange.activeInHierarchy && violet.activeInHierarchy) {
//			testBit = 1;
//		} else {
//			collectible.SetActive (false);
//			red.SetActive (false);
//			orange.SetActive (false);
//			violet.SetActive (false);
//			testBit = 0;
//		}
//
//		yield return null;
//
//		Assert.AreEqual (testBit, 1);
//	}
//    [UnityTest]
//    public IEnumerator S20()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//
//        Vector3 playerPos = player.transform.position;
//
//        if (playerPos.y >= 0.5f)
//        {
//            testBit = 1;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S21()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        player.transform.position = new Vector3(0.0f, 1f, 0);
//
//        Vector3 playerPos = player.transform.position;
//
//        if (playerPos.y > 0.5f)
//        {
//            testBit = 1;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//
//    [UnityTest]
//    public IEnumerator S22()//left orbit 
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitHorizontal(60);
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 60f && cameraRot.z == 0.0f) {
//			testBit = 1;
//		}
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//		Assert.AreEqual (testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S23()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitHorizontal(60);
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 60f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//
//    [UnityTest]
//    public IEnumerator S24() //right orbit
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitHorizontal(-60);
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == -60f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S25()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitHorizontal(-60);
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == -60f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S26() //up orbit
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitVertical(80);
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 80f && cameraRot.y == 0f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S27()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitVertical(80);
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 80f && cameraRot.y == 0f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S28() //down orbit
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitVertical(20);
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 20f && cameraRot.y == 0f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S29() // down orbit
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitVertical(20);
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 20f && cameraRot.y == 0f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S30()//left orbit 
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitHorizontal(60);
//        cameraController.snapHorizontal();
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 0f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S31()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitHorizontal(60);
//        cameraController.snapHorizontal();
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 0f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//
//    [UnityTest]
//    public IEnumerator S32() //right orbit
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitHorizontal(-60);
//        cameraController.snapHorizontal();
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 0f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S33()
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitHorizontal(-60);
//        cameraController.snapHorizontal();
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 60f && cameraRot.y == 0f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S34() //down orbit
//    {
//        int testBit = 0;
//
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//        cameraController.orbitVertical(25);
//
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 25f && cameraRot.y == 0f && cameraRot.z == 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]
//    public IEnumerator S35() // down orbit
//    {
//        int testBit = 0;
//
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
//        CameraController cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
//
//
//        for (float i = 0.0f; i < 1.1f; i += 0.1f)
//        {
//            player.transform.position = new Vector3(0.0f, 0.5f, i);
//        }
//        cameraController.orbitVertical(25);
//        Vector3 playerPos = player.transform.position;
//        Quaternion cameraRot = camera.transform.rotation;
//
//        if (cameraRot.x == 25f && cameraRot.y == 0f && cameraRot.z == 0.0f && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f)
//        {
//            testBit = 1;
//        }
//        else
//        {
//            testBit = 0;
//        }
//
//        yield return null;
//
//        Assert.AreEqual(testBit, 1);
//    }
//
//    [UnityTest]	
//	public IEnumerator S36 () //Player saves current game
//	{
//		int testBit = 0;
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
//		GameObject saveButton = testObjects.transform.Find ("SaveButton").gameObject;
//
//		/*
//		check if game gets saved when saveButton is pressed
//		N/A at the moment
//		*/
//
//		yield return null;
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]	
//	public IEnumerator S37 () // Player loads saved games
//	{
//		int testBit = 0;
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject mainMenu = testObjects.transform.Find ("MainMenu").gameObject;
//		GameObject loadButton = testObjects.transform.Find ("LoadButton").gameObject;
//
//		/*
//		checks if old game is loaded when exitButton is pressed
//		N/A at the moment
//		*/
//
//
//		yield return null;
//		Assert.AreEqual (testBit, 1); 
//	}
//
//	[UnityTest]	
//	public IEnumerator S38 () //Player alters game settings
//	{
//		int testBit = 0;
//
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject mainMenu = testObjects.transform.Find ("MainMenu").gameObject;
//		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
//		GameObject settingsButton1 = testObjects.transform.Find ("SettingsButton(1)").gameObject;
//		GameObject settingsButton2 = testObjects.transform.Find ("SettingsButton(2)").gameObject;
//		GameObject settingsMenu = testObjects.transform.Find ("SettingsMenu").gameObject;
//
//		/*
//		check if game settingsMenu appears when settingsButton is pressed
//		N/A at the moment
//		*/
//
//		yield return null;
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]	
//	public IEnumerator S39 () //User alters game settings
//	{
//		int testBit = 0;
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject pauseMenu = testObjects.transform.Find ("SettingsMenu").gameObject;
//
//		/*
//		checks if settings are updated when user changes them
//		N/A at the moment
//		*/
//
//		yield return null;
//		Assert.AreEqual (testBit, 1);
//	}
//
//	[UnityTest]	
//	public IEnumerator S40 () //Player quits current game
//	{
//		int testBit = 0;
//		GameObject testObjects = GameObject.FindGameObjectWithTag ("TestObjects");
//		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
//		GameObject exitButton = testObjects.transform.Find ("ExitButton").gameObject;
//
//		/*
//		checks if game ends when exitButton is pressed
//		N/A at the moment
//		*/
//
//		yield return null;
//		Assert.AreEqual (testBit, 1);
//	}
//}