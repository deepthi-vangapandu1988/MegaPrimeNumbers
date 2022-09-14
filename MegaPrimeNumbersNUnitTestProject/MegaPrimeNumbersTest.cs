using System.Collections.Generic;
using MegaPrimes;
using NUnit.Framework;

namespace MegaPrimeNumbersNUnitTestProject
{
    public class MegaPrimeNumbersTest
    {
        [Test]
        public void check_not_Prime()
        {
            MegaPrimeNumbers megaPrimeNumbers = new MegaPrimeNumbers();
            var res = megaPrimeNumbers.checkIfPrime(10);
            Assert.AreEqual(false, res);
        }

        [Test]
        public void check_Prime()
        {
            MegaPrimeNumbers megaPrimeNumbers = new MegaPrimeNumbers();
            var res = megaPrimeNumbers.checkIfPrime(59);
            Assert.AreEqual(true, res);
        }

        [Test]
        public void check_not_MegaPrime()
        {
            MegaPrimeNumbers megaPrimeNumbers = new MegaPrimeNumbers();
            var res = megaPrimeNumbers.checkIfMegaPrime(59);
            Assert.AreEqual(false, res);
        }

        [Test]
        public void check_MegaPrime()
        {
            MegaPrimeNumbers megaPrimeNumbers = new MegaPrimeNumbers();
            var res = megaPrimeNumbers.checkIfMegaPrime(37);
            Assert.AreEqual(true, res);
        }

        [Test]
        public void print_mega_prime()
        {
            MegaPrimeNumbers megaprimenumbers = new MegaPrimeNumbers();
            var res = megaprimenumbers.printMegaPrimeNumbers(10);
            Assert.AreEqual(new List<int>{ 2, 3, 5, 7 }, res);
        }

        [Test]
        public void print_mega_prime2()
        {
            MegaPrimeNumbers megaprimenumbers = new MegaPrimeNumbers();
            var res = megaprimenumbers.printMegaPrimeNumbers(37);
            Assert.AreEqual(new List<int> { 2, 3, 5, 7, 23, 37 }, res);
        }
    }
}