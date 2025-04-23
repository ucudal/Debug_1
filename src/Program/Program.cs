//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace Ucu.Poo.Persons
{
    /// <summary>
    /// El programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            AssignVariableWithObject();
            AssignTwoVariablesWithObject();
            CompareDifferentObjects();
            CompareEqualObjects();
            CreateObject();
            IntroducePersons();
        }

        /// <summary>
        /// Ejemplo que muestra la asignación de un objeto a una variable.
        /// </summary>
        public static void AssignVariableWithObject()
        {
            Person lucho;
            lucho = new Person("Luis", "Suárez");
            Console.WriteLine(lucho.FullName);
        }

        /// <summary>
        /// Ejemplo que muestra la asignación del mismo objeto a dos variables.
        /// </summary>
        public static void AssignTwoVariablesWithObject()
        {
            Person colo;
            colo = new Person("Juan Ignacio", "Ramírez");
            Console.WriteLine(colo.FullName);

            Person goleador;
            goleador = colo;
            Console.WriteLine(goleador.FullName);

            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {colo == goleador}");
        }

        /// <summary>
        /// Ejemplo que muestra la comparación de dos objetos diferentes asignados a dos variables diferentes.
        /// </summary>
        public static void CompareDifferentObjects()
        {
            Person chino;
            chino = new Person("Álvaro", "Recoba");
            Console.WriteLine(chino.FullName);

            Person cacique;
            cacique = new Person("Alexander", "Medina");
            Console.WriteLine(cacique.FullName);

            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {chino == cacique}");
        }

        /// <summary>
        /// Ejemplo que muestra la comparación de dos objetos ¿iguales? asignados a dos variables diferentes.
        /// </summary>
        public static void CompareEqualObjects()
        {
            Person chino;
            chino = new Person("Sergio", "Rochet");
            Console.WriteLine(chino.FullName);

            Person arquero;
            arquero = new Person("Sergio", "Rochet");
            Console.WriteLine(arquero.FullName);

            Console.WriteLine($"¿Las dos variables apuntan al mismo objeto? {chino == arquero}");
            Console.WriteLine($"¿Los dos objetos son iguales? {chino.Equals(arquero)}");
        }

        /// <summary>
        /// Ejemplo que muestra el pasaje como parámetro de un objeto.
        /// </summary>
        public static void CreateObject()
        {
            Person artillero = new Person("Luis", "Artime");
            Console.WriteLine($"Antes de cambiar el nombre: {artillero.FullName}");
            UseObject(artillero);
            Console.WriteLine($"Después de cambiar el nombre: {artillero.FullName}");
        }

        /// <summary>
        /// Crea dos personas y las presenta entre sí.
        /// </summary>
        public static void IntroducePersons()
        {
            Person lucho = new Person("Luis", "Suárez");
            Person chino = new Person("Sergio", "Rochet");
            chino.IntroduceTo(lucho);
            lucho.IntroduceTo(chino);
        }

        private static void UseObject(Person person)
        {
            person.FamilyName = "Ganador de Copas";
        }
    }
}