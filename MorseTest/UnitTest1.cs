using NUnit.Framework;
using System;
using MorseLibrary;

namespace MorseTest
{
    // null -> null execption --> DONE
    // "" -> empty --> DONE
    // "5" => .....| --> DONE
    // "123" => .----|..---|...--| --Done
    // "123 5" => .----|..---|...--|#.....|
    // "Daihiana" => -..|.-|..|....|..|.-|-.|.-|
    // "Hola" => ....|---|.-..|.-|
    // "Hola HOLA" => ....|---|.-..|.-|#....|---|.-..|.-|
    
  
    public class Tests
    {
        [Test]
        public void MethodWithNullArgumentExeption()
        {
            Assert.Catch<ArgumentNullException>((() => Morse.Converter(null)));
        }
        
        [Test]
        public void MethodWithEmptyReturn()
        {
            var res = Morse.Converter("");
            Assert.That(res, Is.Empty);
        }
        
        [Test]
        public void MethodReturnOnlyNumber()
        {
            var res = Morse.Converter("5");
            string exp = ".....|";
            Assert.AreEqual(res, exp);
        }
        
        [Test]
        public void MethodReturnNumbers()
        {
            var res = Morse.Converter("123");
            string exp = ".----|..---|...--|";
            Assert.AreEqual(res, exp);
        }
        
        [Test]
        public void MethodReturnNumbersAndSpacing()
        {
            var res = Morse.Converter("123 5");
            string exp = ".----|..---|...--|#.....|";
            Assert.AreEqual(res, exp);
        }
        
        [Test]
        public void MethodReturnNormalText()
        {
            var res = Morse.Converter("daihiana");
            string exp = "-..|.-|..|....|..|.-|-.|.-|";
            Assert.AreEqual(res, exp);
        }
        
        [Test]
        public void MethodReturnNormalTextWithUpperCase()
        {
            var res = Morse.Converter("Hola");
            string exp = "....|---|.-..|.-|";
            Assert.AreEqual(res, exp);
        }
        
        [Test]
        public void MethodReturnNormalTextWithUpperCaseAndSpacing()
        {
            var res = Morse.Converter("Hola HOLA");
            string exp = "....|---|.-..|.-|#....|---|.-..|.-|";
            Assert.AreEqual(res, exp);
        }
    }
}