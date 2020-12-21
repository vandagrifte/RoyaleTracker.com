using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClashCreative.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClashCreative.Controllers
{
    public class CardsController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private ClashContext context;
        private ClashDB clashDB;
        private ClashJson clashJson;

        //string myPlayerTag = "#29PGJURQL";
        //string myClanTag = "#8CYPL8R";

        //ClientFactory is for calling Json Data from Clash Api
        public CardsController(ClashContext c, IHttpClientFactory f)
        {
            context = c;
            _clientFactory = f;
        }

        //page showing all cards directing to the clicked cards wiki
        public async Task<IActionResult> Cards()
        {
            var cards = await GetCards();
            return View(cards);
        }
        public async Task<List<Card>> GetCards()
        {
            ClashJson clashJson = new ClashJson(_clientFactory);
            var cards = await clashJson.GetAllCards();
            if (context.Cards.Count() < cards.Count()) 
            { 
                foreach (Card c in cards)
                {
                    if(!context.Cards.Any(d=>d.Id==c.Id))
                    {
                        context.Cards.Add(c);
                    }
                }
                context.SaveChanges(); 
            }
            return (cards);
        }





        //the top 10 ranking decks out of the collection in the DB
        //This probably should be delegated to it's own function somewhere but alas
        public async Task<IActionResult> Decks()
        {
            //gets top decks in the DB
            var decks = await GetTopDecks();

            //passes the list of top 10 decks to the View
            return View(decks);
        }

        public async Task<List<Deck>> GetTopDecks()
        {
            //My Json and DB handling classes
            ClashJson clashJson = new ClashJson(_clientFactory);
            ClashDB clashDB = new ClashDB(context);

            //gets all logged decks(every deck configuraiton is assigned a unique ID)
            var allDecks = context.Decks.ToList();

            //list to hold highest ranking decks
            List<Deck> notableDecks = new List<Deck>();

            //there needs to be at least 10 for a top 10
            if (allDecks.Count() > 10)
            {

                foreach (Deck d in allDecks)
                {
                    Deck temp = await GetDeckWinLossRatio(d);
                    d.Wins = temp.Wins;
                    d.Loss = temp.Loss;
                    d.WinLossRate = temp.WinLossRate;
                }

                
                //lists decks with wins more than five(so that it only pulls decks that have sufficient-ish data)
                //orders the decks by winLoss rate and grabs the highest 10
                notableDecks = allDecks.OrderByDescending(d => d.WinLossRate).ToList().GetRange(0, 10);

                //the selected 10 decks are cycled through and the associated card classes are filled in with all their data from the DB
                //(cards have static ID's and they are used to access additional details about the cards played other than Id)
                var cards = context.Cards.ToList();
                notableDecks.ForEach((d => { d.SetCards(context); }));
            }
            
            return notableDecks;
        }

        public async Task<Deck> GetDeckWinLossRatio(Deck deck)
        {
            List<Battle> deckBattles = new List<Battle>();

            //gets pvp battles using the deck given
            var battles = context.Battles.Where(t => t.Type == "PvP").Where(t => (t.Team1DeckAId == deck.DeckId || t.Team2DeckAId == deck.DeckId));

            //loops through and gets win loss for each battle played with deck
            foreach (Battle b in battles)
            {
                if (b.Team1DeckAId == deck.DeckId)
                {
                    if (b.Team1Win == true) { deck.Wins++; } else deck.Loss++;
                }

                else
                {
                    if (b.Team2Win == true) { deck.Wins++; } else deck.Loss++;
                }
            }

            //avoid divide by zero errors and get win/loss rate
            if (deck.Loss == 0) { deck.WinLossRate = deck.Wins / 1; }
            else deck.WinLossRate = deck.Wins / deck.Loss;

            return deck;
        }

    }
}
