using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Ekku Sipilä
/// @version 19.10.2020
/// <summary>
/// 
/// </summary>
public class Day2
{
    /// <summary>
    /// Good morning! Here's your coding interview problem for today.
    /// This problem was asked by Uber.
    /// Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
    /// For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].
    /// Follow-up: what if you can't use division?
    /// </summary>
    public static void Main()
    {

    }

    /// <summary>
    /// Palauttaa taulukon käännettynä niin, että uuden taulukon alkiot koostuvat vanhan taulukon kaikkien alkioiden, paitsi kyseessä olevan alkion, tulosta.
    /// </summary>
    /// <param name="taulukko">Käännettävä taulukko</param>
    /// <returns>Käännetyn taulukon</returns>
    /// <example>
    /// <pre name="test">
    ///  KaannaTuloTaulukko(new int[] { 1, 2, 3, 4, 5 }) === new int[] { 120, 60, 40, 30, 24 };
    ///  KaannaTuloTaulukko(new int[] { 3, 2, 1 }) === new int[] { 2, 3, 6 };
    ///  KaannaTuloTaulukko(new int[] { 2 }) === new int[] { 1 };
    ///  KaannaTuloTaulukko(new int[] { }) === new int[] { };
    /// </pre>
    /// </example>
    public static int[] KaannaTuloTaulukko(int[] taulukko)
    {
        int[] uusiTaulukko = new int[taulukko.Length];
        for (int i = 0; i < taulukko.Length; i++)
        {
            int uusiArvo = 1;
            for (int j = 0; j < taulukko.Length; j++)
            {
                if (i != j) uusiArvo *= taulukko[j];
                uusiTaulukko[i] = uusiArvo;
            }
        }
        
        return uusiTaulukko;
    }
}
