using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class MenuTest
    {

        [UnityTest]
        public IEnumerator MenuTestWithEnumeratorPasses()
        {
            SceneManager.LoadScene(0);
            Scene thescene = SceneManager.GetActiveScene();
            Assert.That(SceneManager.GetSceneByName("MainMenu").isLoaded, Is.EqualTo(false));

            SceneManager.LoadScene(1);
            yield return new WaitForSeconds(10f);

            thescene = SceneManager.GetActiveScene();
            Assert.That(SceneManager.GetSceneByName("Main").isLoaded, Is.EqualTo(true));
            yield return null;
        }
    }
}