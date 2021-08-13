using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LoginTest
    {
        // A Test behaves as an ordinary method
        //[TestCase("User1@gmail.com","admin")]
        //[TestCase("User1@gmail.com","Admin")]
        //[TestCase("User2@gmail.com","admin")]
        //[TestCase("User3@gmail.com","Admin")]
        [Test]
        public void LoginTestSimplePasses(){
            // Use the Assert class to test conditions
            var login = new Login();
            
            int puntaje = login.validarLogin("User1@gmail.com", "admin");

            Assert.AreEquals(1, puntaje);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator LoginTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
