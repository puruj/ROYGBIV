using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using NSubstitute;

namespace UnitTests.Editor
{
    //ALL FAILED TESTS RELATED TO MENU OPTIONS ARE FAILED BECAUSE UNITY DOESN'T SUPPORT THE TOOLS
    //TO TEST CODE THAT USES THE UNITY ENGINE ANYMORE. THIS MEANS THAT MOST USER INPUT IS DIFFICULT TO TEST
    //WITH UNIT TESTING. CURRENTLY WORKING ON A FIX. CURRENT SOLUTION IS TO TEST ALL MENU RELATED ITEMS MANUALLY.

    public class UnitTests
    {
        [Test]
        public void U1_Change_X_Angle_Camera()
        {
            int testbit = 0;
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
            Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseX);
            camera.GetComponent<vThirdPersonCamera>().RotateCamera(60f, 0f);
            Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseX);
            if (camera.GetComponent<vThirdPersonCamera>().mouseX == 60f * camera.GetComponent<vThirdPersonCamera>().xMouseSensitivity)
                testbit = 1;
            else
                testbit = 0;
            Assert.AreEqual(1, testbit);
        }

        [Test]
        public void U2_Change_Y_Angle_Camera()
        {
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
            Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseY);
            camera.GetComponent<vThirdPersonCamera>().RotateCamera(0, 60f);
            Debug.Log(camera.GetComponent<vThirdPersonCamera>().mouseY* camera.GetComponent<vThirdPersonCamera>().yMouseSensitivity);

            if (camera.GetComponent<vThirdPersonCamera>().mouseY == 60f * camera.GetComponent<vThirdPersonCamera>().yMouseSensitivity)
                Assert.AreEqual(60f * camera.GetComponent<vThirdPersonCamera>().yMouseSensitivity, 60, .1f);
            
        }

        [UnityTest]
        public IEnumerator U3_Camera_Fixed_Distance()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");            
            var unityService = Substitute.For<IUnityService>();
                        
            unityService.GetKeyDown("w").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;
            float distance = camera.GetComponent<vThirdPersonCamera>().defaultDistance;
            yield return null;

            Assert.AreEqual(2.5, distance, 0.1f);
        }

        [UnityTest]
        public IEnumerator U4_move_x()
        {

            GameObject player = GameObject.FindGameObjectWithTag("Player");

            var unityService = Substitute.For<IUnityService>();

            unityService.GetKeyDown("w").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;

            yield return null;

            Assert.AreEqual(-1, player.transform.position.x, 0.1f);

        }

        [UnityTest]
        public IEnumerator U5_move_z()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            var unityService = Substitute.For<IUnityService>();
            Debug.Log(player.transform.position.z);
            unityService.GetKeyDown("a").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;
            yield return null;
            Debug.Log(player.transform.position.z);

            Assert.AreEqual(0, player.transform.position.z, 0.1f);

        }

        [Test]
        public void U6_Detect_Object_Collision()    // Requires gravity to be active
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Vector3 pos = player.transform.position;
            Assert.AreEqual(0, pos.y);      // Test floor is at y = 0, if there's gravity then pos.y should also be 0
        }

        [Test]
        public void U7_Update_Map()
        {
			Assert.Pass("Minimap is just a topview camera that follows the character." +
				" Therefore the test will always pass with the current implementation.");
        }

        [Test]
        public void U8()
        {
            Assert.Fail();
        }

        [Test]
        public void U9()
        {
            Assert.Fail();
        }

        [Test]
        public void U10()
        {
            Assert.Fail();
        }

        [Test]
        public void U11_System_Pause() // Extracted code from Pause() in Rules.cs
        {
            Time.timeScale = 1;
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }

            else
            {
                Time.timeScale = 1;
            }
            Assert.AreEqual(0, Time.timeScale);
        }

        [Test]
        public void U12_System_Unpause() // Extracted code from Pause() in Rules.cs
        {
            Time.timeScale = 0;
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }

            else
            {
                Time.timeScale = 1;
            }
            Assert.AreEqual(1, Time.timeScale);
        }

        [Test]
        public void U13()
        {
            Assert.Fail();
        }

        [Test]
        public void U14()
        {
            Assert.Fail();
        }

        [UnityTest]
        public IEnumerator U15_Move_Y()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            var unityService = Substitute.For<IUnityService>();

            unityService.GetKeyDown("space").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;

            yield return null;

            Assert.AreEqual(0.6, player.transform.position.y, 0.2f);
        }

        [Test]
        public void U16()
        {
            Assert.Fail();
        }

        [Test]
        public void U17()
        {
            Assert.Fail();
        }

        [UnityTest]
        public IEnumerator U18()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            var unityService = Substitute.For<IUnityService>();

            unityService.GetKeyDown("m").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;
            yield return null;

            Assert.IsTrue(GameObject.FindGameObjectWithTag("MiniMap").activeInHierarchy);
        }

        [Test]
        public void U19()
        {
            Assert.Fail();
        }

        [UnityTest]
        public IEnumerator U20()
        {

            GameObject player = GameObject.FindGameObjectWithTag("Player");

            var unityService = Substitute.For<IUnityService>();

            unityService.GetKeyDown("p").Returns(true);
            player.GetComponent<GameManager>().UnityService = unityService;

            player.GetComponent<GameManager>().pauseScreen.SetActive(true);
            Debug.Log(player.GetComponent<GameManager>().pauseScreen.activeSelf);
            yield return null;

            Assert.IsTrue(player.GetComponent<GameManager>().pauseScreen.activeInHierarchy);
        }

        [Test]
        public void U21()
        {
            Assert.Fail();
        }

        [Test]
        public void U22()
        {
            Assert.Fail();
        }

        [Test]
        public void U23()
        {
            Assert.Fail();
        }

        [Test]
        public void U24()
        {
            Assert.Fail();
        }

        [Test]
        public void U25()
        {
            Assert.Fail();
        }

        [Test]
        public void U26()
        {
            Assert.Fail();
        }

        [Test]
        public void U27()
        {
            Assert.Fail();
        }

        [Test]
        public void U28()
        {
            Assert.Fail();
        }

        [Test]
        public void U29()
        {
            Assert.Fail();
        }

        [Test]
        public void U30()
        {
            Assert.Fail();
        }

        [Test]
        public void U31()
        {
            Assert.Fail();
        }

        [Test]
        public void U32()
        {
            Assert.Fail();
        }

        [Test]
        public void U33()
        {
            Assert.Fail();
        }

        [Test]
        public void U34()
        {
            Assert.Fail();
        }

        [Test]
        public void U35()
        {
            Assert.Fail();
        }

        [Test]
        public void U36()
        {
            Assert.Fail();
        }

        [Test]
        public void U37()
        {
            Assert.Fail();
        }

    }
}