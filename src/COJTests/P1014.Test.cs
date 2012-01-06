﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using Lemolsoft.Practicas.Coj.CojTests.NUnit;

namespace Lemolsoft.Practicas.Coj.Problemas.Tests
{
    [TestFixture]
    public class P1014Test : ProblemaTest<P1014>
    {

        #region Teste de Funcoes

        #endregion

        #region Executivos

        [Test]
        public void Teste_Proposto()
        {

            NovaEntrada(@"1
10 17 39 49 64
12 21 36 55 62
14 25 52 70
7 19 32 56 68
5 24 34 54 71
1 2 3 4 5 6 7 8 9 10
11 12 13 14 15 16 17 18 19 20
21 22 23 24 25 26 27 28 29 30
31 32 33 34 35 36 37 38 39 40
41 42 43 44 45 46 47 48 49 50
51 52 53 54 55 56 57 58 59 60
61 62 63 64 65 66 67 68 69 70
71 72 73 74 75");

            Problema.Executar();

            ExpectSaida(@"BINGO after 14 numbers announced");

        }

        #endregion

    }
}
