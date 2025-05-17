using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string john = "♦️6♥️2♠️3♦️5♠️J♣️Q♠️K♣️7♦️2♣️5♥️5♥️10♠️A";
        string uncle = "♠️2♠️3♠️5♥️J♥️Q♥️K♣️8♣️9♣️10♦️4♦️5♦️6♦️7";

        string result = SortCards(john, uncle);
        Console.WriteLine(result);
    }

    static string SortCards(string john, string uncle)
    {
        // Разделяем карты Джона и Дяди на массивы
        string[] johnCards = john.Split(' ');
        string[] uncleCards = uncle.Split(' ');

        // Создаем список для отслеживания порядка карт
        var order = new Dictionary<string, int>();

        for (int i = 0; i < uncleCards.Length; i++)
        {
            string card = uncleCards[i];
            // Используем уникальные масти + значения для сортировки
            string suitValue = card[0] + card[1..]; // Масть + Значение
            order[suitValue] = i;
        }

        // Сортируем карты Джона по порядку Дяди
        var sortedJohnCards = johnCards
            .Select(card => new { Card = card, SortKey = order.GetValueOrDefault(card[0] + card[1..], -1) })
            .Where(x => x.SortKey >= 0) // Убираем карты, которые не входят в порядок Дяди
            .OrderBy(x => x.SortKey) // Сортируем по порядку
            .ThenBy(x => Array.IndexOf(GetCardRanks(), x.Card[1..])) // Сортируем по рангу
            .Select(x => x.Card)
            .ToArray();

        return string.Join(" ", sortedJohnCards);
    }

    static string[] GetCardRanks()
    {
        return new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    }
}
