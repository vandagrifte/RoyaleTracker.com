﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClashCreative.Models
{
    public class ClashJson
    {
        private readonly IHttpClientFactory _clientFactory;

        public ClashJson(IHttpClientFactory f)
        {
            _clientFactory = f;
            //Player p = await GetPlayerData("#29PGJURQL");
        }

        //returns the Player Object from deserielized JSON
        //returns player with all json items retrieved
        //current deck ID and Team ID will need to be added in DB Class
        public async Task<Player> GetPlayerData(string playerTag)
        {

            if (playerTag != null)
            {
                try
                {
                    //Note: Makesure faulty data doesn't make it through
                    string connectionString = "/v1/players/%23" + playerTag.Substring(1);
                    var client = _clientFactory.CreateClient("API Client");
                    var result = await client.GetAsync(connectionString);
                    Console.WriteLine();

                    if (result.IsSuccessStatusCode)
                    {
                        var content = await result.Content.ReadAsStringAsync();
                        var player = JsonConvert.DeserializeObject<Player>(content);
                        if (player.ClanTag != null)
                        {
                            var clan = await GetClanData(player.ClanTag);
                            player.Clan = clan;
                            player.LastSeen = clan.MemberList.Where(c => c.Tag == player.Tag).FirstOrDefault().LastSeen ;
                        }

                        player.CardsDiscovered = player.Cards.Count();
                        player.CurrentFavouriteCardId = player.CurrentFavouriteCard.Id;
                        return player;
                    }
                }
                catch { return null; }
            }
            return null;
        }

        public async Task<List<Card>> GetAllCards()
        {
            string connectionString = "/v1/cards?";

            var client = _clientFactory.CreateClient("API Client");
            var result = await client.GetAsync(connectionString);

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();

                //removing the base layer from called Json
                content = content.Substring(9, content.Length - 10);
                List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(content);
                foreach (Card c in cards)
                {
                    c.SetUrl();
                }
                return cards;
            }
            return null;
        }


        //returns Clan Object from deserielized JSON
        public async Task<Clan> GetClanData(string clanTag)
        {
            if (clanTag != null)
            {
                try
                {
                    string connectionString = "/v1/clans/%23" + clanTag.Substring(1);

                    var client = _clientFactory.CreateClient("API Client");

                    var result = await client.GetAsync(connectionString);

                    if (result.IsSuccessStatusCode)
                    {
                        var content = await result.Content.ReadAsStringAsync();
                        var clan = JsonConvert.DeserializeObject<Clan>(content);
                        if (clan.Location.Count == 4)
                        {
                            clan.LocationCode = clan.Location["countryCode"];
                        }
                        else { Console.WriteLine(); }
                        return clan;

                    }
                }
                catch { return null; }
            }
            return null;
        }
        //public async Task<List<Player>> GetClanMembers(string clanTag)
        //{
        //    List<Player> players = new List<Player>();
        //    Player p;
        //    Clan clan = await GetClanData(clanTag);
        //    clan.MemberList.ForEach(m => {


        //});
        //   //p.LastSeen = clan.MemberList[i].LastSeen; p.UpdateTime = now;

        //    return players;
        //}



        //gets battle data from JSON/api
        public async Task<List<Battle>> GetListOfBattles(string playerID)
        {
            string connectionString = "/v1/players/%23" + playerID.Substring(1) + "/battlelog/";

            var client = _clientFactory.CreateClient("API Client");

            var result = await client.GetAsync(connectionString);

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var battles = JsonConvert.DeserializeObject<List<Battle>>(content);
                // battles.ForEach(b => { b.Opponent.})
                return battles;
            }
            return null;
        }
    }
}
