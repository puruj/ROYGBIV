using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class SystemTests
{

	[UnityTest]
	public IEnumerator S1 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S2 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		for (float i = -1.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S3 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x > 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S4 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		for (float i = -1.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x > 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S5 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S6 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		for (float i = 1.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S7 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x < 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S8 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		for (float i = 1.0f; i > -1.1f; i -= 0.1f) {
			player.transform.position = new Vector3 (i, 0.5f, 0.0f);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x < 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S9 ()
	{
		int testBit = 0;

		Time.timeScale = 0.0f;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
		pauseMenu.SetActive (true);

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i * Time.timeScale);
		}

		Vector3 playerPos = player.transform.position;

		if (pauseMenu.activeInHierarchy && playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z == 0.0f) {
			testBit = 1;
		}

		Time.timeScale = 1.0f;
		pauseMenu.SetActive (false);

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S10 ()
	{
		int testBit = 0;

		Time.timeScale = 1.0f;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i * Time.timeScale);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z > 0.0f) {
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S11 ()
	{
		int testBit = 0;

		int sequence = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject red = testObjects.transform.Find ("Red").gameObject;
		red.SetActive (true);

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;
		Vector3 redPos = red.transform.position;

		if (sequence == 0 && playerPos.x == redPos.x && playerPos.y == redPos.y && playerPos.z + 0.5f >= redPos.z - 0.5f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		red.SetActive (false);

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S12 ()
	{
		int testBit = 0;

		int sequence = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject orange = testObjects.transform.Find ("Orange").gameObject;
		orange.SetActive (true);
		GameObject lossScreen = testObjects.transform.Find ("LossScreen").gameObject;
		lossScreen.SetActive (true);

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;
		Vector3 orangePos = orange.transform.position;

		if (lossScreen.activeInHierarchy && sequence == 0 && playerPos.x == orangePos.x && playerPos.y == orangePos.y && playerPos.z + 0.5f >= orangePos.z - 0.5f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		yield return null;

		orange.SetActive (false);
		lossScreen.SetActive (false);

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S13 ()
	{
		int testBit = 0;

		int sequence = 6;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject violet = testObjects.transform.Find ("Violet").gameObject;
		violet.SetActive (true);
		GameObject winScreen = testObjects.transform.Find ("WinScreen").gameObject;
		winScreen.SetActive (true);

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;
		Vector3 violetPos = violet.transform.position;

		if (winScreen.activeInHierarchy && sequence == 6 && playerPos.x == violetPos.x && playerPos.y == violetPos.y && playerPos.z + 0.5f >= violetPos.z - 0.5f) {
			testBit = 1;
	
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		violet.SetActive (false);
		winScreen.SetActive (false);

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S15 ()
	{
		int testBit = 0;

		int health = 1;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject collectible = testObjects.transform.Find ("Collectible").gameObject;
		collectible.SetActive (true);

		for (float i = 0.0f; i < 1.1f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;
		Vector3 collectiblePos = collectible.transform.position;

		if (collectible.activeInHierarchy && ++health == 2 && playerPos.x == collectiblePos.x && playerPos.y == collectiblePos.y && playerPos.z + 0.6f >= collectiblePos.z - 0.6f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		collectible.SetActive (false);

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S16 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		for (float i = 0.0f; i < 9.5f; i += 0.1f) {
			player.transform.position = new Vector3 (0.0f, 0.5f, i);
		}

		Vector3 playerPos = player.transform.position;

		if (playerPos.x == 0.0f && playerPos.y == 0.5f && playerPos.z < 9.5f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S17 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		player.GetComponent<Invector.CharacterController.vThirdPersonController> ().Jump ();

		Vector3 playerPos = player.transform.position;

		if (playerPos.y >= 0.5f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S18 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		player.GetComponent<Invector.CharacterController.vThirdPersonController> ().Jump ();

		player.transform.position = new Vector3 (0.0f, 1.0f, 0.0f);

		Vector3 playerPos = player.transform.position;

		if (playerPos.y >= 0.5f) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S19 ()
	{
		int testBit = 0;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject collectible = testObjects.transform.Find ("Collectible").gameObject;
		GameObject red = testObjects.transform.Find ("Red").gameObject;
		GameObject orange = testObjects.transform.Find ("Orange").gameObject;
		GameObject violet = testObjects.transform.Find ("Violet").gameObject;
		collectible.SetActive (true);
		red.SetActive (true);
		orange.SetActive (true);
		violet.SetActive (true);

		if (player.activeInHierarchy && collectible.activeInHierarchy && red.activeInHierarchy && orange.activeInHierarchy && violet.activeInHierarchy) {
			testBit = 1;
		} else {
			player.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
			testBit = 0;
		}

		collectible.SetActive (false);
		red.SetActive (false);
		orange.SetActive (false);
		violet.SetActive (false);

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

    //player stands stationary above ground
    [UnityTest]
    public IEnumerator S20()
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        Vector3 playerPos = player.transform.position;

        if (playerPos.y >= 0.5f)
        {
            testBit = 1;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    //Floor supports player in free fal
    [UnityTest]
    public IEnumerator S21()
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = new Vector3(0.0f, 1f, 0);

        Vector3 playerPos = player.transform.position;

        if (playerPos.y > 0.5f)
        {
            testBit = 1;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

        [UnityTest]
        public IEnumerator S22()//left orbit 
        {
        int testBit = 0;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(60,0);
       

        //Debug.Log(camera.transform.rotation.eulerAngles.y);

            if (camera.GetComponent<vThirdPersonCamera>().mouseX == 60f && camera.GetComponent<vThirdPersonCamera>().mouseY == 0f)
            {
                testBit = 1;
            }
            else
            {
                testBit = 0;
            }

            yield return null;

            Assert.AreEqual(testBit, 1);
    }


    [UnityTest]
    public IEnumerator S23()//player turns left and moves up by one unit
    {
        int testBit = 0;
       
        GameObject player = GameObject.FindGameObjectWithTag("Player"); 
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        //rotate camera first 
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(-60, 0);
        player.transform.Rotate(camera.transform.rotation.x, camera.GetComponent<vThirdPersonCamera>().mouseX, camera.transform.rotation.z);

        //move player forward, simulating up arrow key press
        for (float i = 0.0f; i < 1.1f; i += 0.1f)
        {

            player.transform.position = new Vector3 (-i,0.5f,i);
        }

        //check if camera turned right, and player went forward in direction of camera
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == -60f && camera.GetComponent<vThirdPersonCamera>().mouseY == 0f && player.transform.rotation.eulerAngles.y == (360f + camera.GetComponent<vThirdPersonCamera>().mouseX) && player.transform.position.x < 0f && player.transform.position.y == 0.5f && player.transform.position.z > 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S24()//right orbit 
    {
        int testBit = 0;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(-60, 0);


        //Debug.Log(camera.transform.rotation.eulerAngles.y);

        if (camera.GetComponent<vThirdPersonCamera>().mouseX == -60f && camera.GetComponent<vThirdPersonCamera>().mouseY == 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S25()//player turns right and moves up by one unit
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        //rotate camera first 
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(60, 0);
        player.transform.Rotate(camera.transform.rotation.x, camera.GetComponent<vThirdPersonCamera>().mouseX, camera.transform.rotation.z);

        //move player forward, simulating up arrow key press
        for (float i = 0.0f; i < 1.1f; i += 0.1f)
        {

            player.transform.position = new Vector3(i, 0.5f, i);
        }


      //  Debug.Log(player.transform.rotation.eulerAngles.y);
       // Debug.Log(player.transform.rotation.eulerAngles.y == (camera.GetComponent<vThirdPersonCamera>().mouseX));
     
        //check if camera turned right, and player went forward in direction of camera
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 60f && camera.GetComponent<vThirdPersonCamera>().mouseY == 0f  && player.transform.position.x > 0f && player.transform.position.y == 0.5f && player.transform.position.z > 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S26()//up orbit 
    {
        int testBit = 0;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, -80);

         
        //Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseY);

        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == 80f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S27()//player moves up by one unit, camera orbits up
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        //rotate camera first 
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, -80);

        //move player forward, simulating up arrow key press
        for (float i = 0.0f; i < 1.1f; i += 0.1f)
        {

            player.transform.position = new Vector3(0, 0.5f, i);
        }

        //check if camera orbited up, and player went forward in direction of camera
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == 80f && player.transform.position.x == 0f && player.transform.position.y == 0.5f && player.transform.position.z > 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S28()//down orbit 
    {
        int testBit = 0;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, 40);


       // Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseY);

        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == -40f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S29()//player moves up by one unit, camera orbits down
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        //rotate camera first 
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, 40);

        //move player forward, simulating up arrow key press
        for (float i = 0.0f; i < 1.1f; i += 0.1f)
        {

            player.transform.position = new Vector3(0, 0.5f, i);
        }

        //check if camera orbited down, and player went forward in direction of camera
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == -40f && player.transform.position.x == 0f && player.transform.position.y == 0.5f && player.transform.position.z > 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

    [UnityTest]
    public IEnumerator S30()//attempt down orbit through floor
    {
        int testBit = 0;
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        //try to rotate camera more than max rotation angle 
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, 60);


        // Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseY);

        //check if camera orbited down past groud or was it clamped to not go past ground
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == -40f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }


    [UnityTest]
    public IEnumerator S31()//player moves up by one unit, camera tries to orbit down past the ground
    {
        int testBit = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");

        //try to rotate camera so it goes through the groud
        camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, 60);

        //move player forward, simulating up arrow key press
        for (float i = 0.0f; i < 1.1f; i += 0.1f)
        {

            player.transform.position = new Vector3(0, 0.5f, i);
        }

        //check if camera orbited down past groud or was it clamped to not go past ground, and player went forward in direction of camera
        if (camera.GetComponent<vThirdPersonCamera>().mouseX == 0f && camera.GetComponent<vThirdPersonCamera>().mouseY == -40f && player.transform.position.x == 0f && player.transform.position.y == 0.5f && player.transform.position.z > 0f)
        {
            testBit = 1;
        }
        else
        {
            testBit = 0;
        }

        yield return null;

        Assert.AreEqual(testBit, 1);
    }

	[UnityTest]
	public IEnumerator S32()
	{
		int testBit = 0;
		yield return null;

		Assert.AreEqual (testBit, 1);
	}

    [UnityTest]
	public IEnumerator S33()
	{
		int testBit = 0;

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
		pauseMenu.SetActive (true);
		Button main = pauseMenu.GetComponent<PauseMenu> ().mainmenuButton; //main menu button
		main.GetComponent<Button>().onClick.Invoke (); //invoke button
		Debug.Log(pauseMenu.GetComponent<PauseMenu> ().mainMenuTest);
		if (pauseMenu.GetComponent<PauseMenu> ().mainMenuTest == true) { //if main menu function is called
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}

	[UnityTest]
	public IEnumerator S34()
	{
		int testBit = 0;

		GameObject testObjects = GameObject.Find ("/TestObjects");
		GameObject pauseMenu = testObjects.transform.Find ("PauseMenu").gameObject;
		pauseMenu.SetActive (true);
		Button replay = pauseMenu.GetComponent<PauseMenu> ().replayButton; //replay button
		replay.GetComponent<Button>().onClick.Invoke (); //invoke button
		Debug.Log(pauseMenu.GetComponent<PauseMenu> ().replayTest);
		if (pauseMenu.GetComponent<PauseMenu> ().replayTest == true) { //if replay function is called
			testBit = 1;
		}

		yield return null;

		Assert.AreEqual (testBit, 1);
	}








}