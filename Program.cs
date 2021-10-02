using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<Item> Items = new List<Item>{
                new ItemDexterity(10,20),
                new ItemAgedBrie(2,0),
                new ItemElixir(5,7),
                new ItemSulfuras(0,80),
                new ItemSulfuras(-1,80),
                new ItemBackstage( 15, 20),
                new ItemBackstage( 10, 49),
                new ItemBackstage( 5, 49),
				// this conjured item does not work properly yet
				new ItemConjuredManaCake(3,6)
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                foreach(var item in Items)
                {
                    item.UpdateSellIn();
                    item.UpdateQuality();
                }
            }
        }
    }
}
