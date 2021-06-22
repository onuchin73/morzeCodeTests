using NUnit.Framework;
using System.IO;
using System;

namespace morzeCodeTests
{
    public class Tests
    {

        [Test] // 1. Пример позитивного тест кейса (Протестируем правильность вывода слов)
        public void morseCodeTest_1()
        {
            try
            {
                string morzeMessageTest_1 = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
                string expectedTest_1 = "Your message: HELLO WORLD";

                string actual = morzeCode.Program.morzeDecoder(morzeMessageTest_1);

                Assert.AreEqual(expectedTest_1, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("Something went wrong, check the test: " + ex.Message);
            }
        }

        [Test]
        public void morseCodeTest_1_1()
        {
            var morzeMessageTest_1_1 = ". ....";
            Assert.AreEqual("Your message: EH", morzeCode.Program.morzeDecoder(morzeMessageTest_1_1));
        }

        [Test] // 2. Пример позитивного тест кейса (Протестируем правильность вывода 1 буквы)
        public void morseCodeTest_2()
        {
            try
            {
                string morzeMessage = "....";
                string expected = "Your message: H";

                string actual = morzeCode.Program.morzeDecoder(morzeMessage);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("Something went wrong, check the test: " + ex.Message);
            }
        }

        [Test] // 3. Пример позитивного тест кейса (Протестируем правильность вывода слов)
        public void morseCodeTest_3()
        {
            try
            {
                string morzeMessage = "--. --- --- -..   .- ..-. - . .-. .... --- --- ....";
                string expected = "Your message: GOOD AFTERHOOH";

                string actual = morzeCode.Program.morzeDecoder(morzeMessage);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("Something went wrong, check the test: " + ex.Message);
            }
        }

        [Test] // 1. Пример негативного тест кейса (Проверка на неверно введённые символы)
        public void morseCodeTest_4()
        {
            try
            {
                string morzeMessage = ".- -... -.-.   .---- ..--- ...--";
                string expected = "Your message: ABC ***";

                string actual = morzeCode.Program.morzeDecoder(morzeMessage);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("Something went wrong, check the test: " + ex.Message);
            }
        }

        [Test] // 2. Пример негативного тест кейса (Проверка на введённые слова)
        public void morseCodeTest_5()
        {
            try
            {
                string morzeMessage = "HELLO WORLD";
                string expected = "Your message: **";

                string actual = morzeCode.Program.morzeDecoder(morzeMessage);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("Something went wrong, check the test: " + ex.Message);
            }
        }

    }
}