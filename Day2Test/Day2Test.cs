using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using static Day2;

	[TestFixture]
	public  class TestDay2
	{
		[Test]
		public  void TestKaannaTuloTaulukko31()
		{
			Assert.AreEqual( new int[] { 120, 60, 40, 30, 24 }, KaannaTuloTaulukko(new int[] { 1, 2, 3, 4, 5 }) , "in method KaannaTuloTaulukko, line 32");
			Assert.AreEqual( new int[] { 2, 3, 6 }, KaannaTuloTaulukko(new int[] { 3, 2, 1 }) , "in method KaannaTuloTaulukko, line 33");
			Assert.AreEqual( new int[] { 1 }, KaannaTuloTaulukko(new int[] { 2 }) , "in method KaannaTuloTaulukko, line 34");
			Assert.AreEqual( new int[] { }, KaannaTuloTaulukko(new int[] { }) , "in method KaannaTuloTaulukko, line 35");
		}
	}

