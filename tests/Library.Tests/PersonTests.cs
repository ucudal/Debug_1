//-----------------------------------------------------------------------------
// <copyright file="PersonTests.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.IO;
using NUnit.Framework;
using Ucu.Poo.Persons;

namespace Ucu.Poo.Persons.Tests
{
    /// <summary>
    /// Tests para la clase <see cref="Person"/>.
    /// </summary>
    public class PersonTests
    {
        /// <summary>
        /// Prueba getters y setters de la clase <see cref="Person"/>.
        /// </summary>
        [Test]
        public void TestProperties()
        {
            const string name = "Nombre";
            const string familyName = "Apellido";

            Person person = new Person(name, familyName);

            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(familyName, person.FamilyName);

            const string anotherName = "John";
            const string anotherFamilyName = "Doe";

            person.Name = anotherName;
            person.FamilyName = anotherFamilyName;

            Assert.AreEqual(anotherName, person.Name);
            Assert.AreEqual(anotherFamilyName, person.FamilyName);
        }

        /// <summary>
        /// Prueba el método <see cref="Person.FullName"/>.
        /// </summary>
        [Test]
        public void TestFullName()
        {
            const string name = "Nombre";
            const string familyName = "Apellido";
            const string fullName = name + " " + familyName;

            Person person = new Person(name, familyName);

            Assert.AreEqual(fullName, person.FullName);
        }

        /// <summary>
        /// Prueba el método <see cref="Person.IntroduceTo"/>.
        /// </summary>
        [Test]
        public void TestIntroduceTo()
        {
            const string name = "One";
            const string anotherName = "Two";
            const string hi = "Hola, Two, mi nombre es One";

            Person one = new Person(name, string.Empty);
            Person two = new Person(anotherName, string.Empty);

            using (var consoleContent = new StringWriter())
            {
                Console.SetOut(consoleContent);

                one.IntroduceTo(two);

                Assert.That(consoleContent.ToString(), Does.Contain(hi));
            }
        }

        /// <summary>
        /// Prueba la propiedad <see cref="Person.Age"/>.
        /// </summary>
        [Test]
        public void TestAge()
        {
            Person person = new Person("Nombre", "Apellido");
            int age = 10;
            DateTime birthDate = DateTime.Today.AddYears(-age);

            person.BirthDate = birthDate;

            Assert.AreEqual(age, person.Age);
        }
    }
}