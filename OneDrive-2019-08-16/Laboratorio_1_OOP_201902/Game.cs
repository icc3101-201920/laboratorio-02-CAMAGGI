﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Game
    {
        //Atributos
        private Player[] players;
        private Player activePlayer;
        private Board boardGame;
        private bool endGame;

        //Constructor
        public Game()
        {
            Random random = new Random();
            players = new Player[2] { new Player(), new Player() };
            ActivePlayer = players[random.Next(0, 2)];
            boardGame = new Board();
            EndGame = false;

        }
        //Propiedades
        public Player[] Players
        {
            get
            {
                return this.players;
            }
        }
        public Player ActivePlayer
        {
            get
            {
                return this.activePlayer;
            }
            set
            {
                activePlayer = value;
            }
        }
        public Board BoardGame
        {
            get
            {
                return this.boardGame;
            }
        }
        public bool EndGame
        {
            get
            {
                return this.endGame;
            }
            set
            {
                endGame = value;
            }
        }

        //Metodos
        public bool CheckIfEndGame()
        {
            if (Players[0].LifePoints == 0 || Players[1].LifePoints == 0)
            {
                return true;
            }
            return false;
        }
        public string GetWinner()
        {
            string Winner = Players[0].Id.ToString();
            if (Players[0].LifePoints == 0)
            {
                Winner = Players[1].Id.ToString();
            }
            return "Player  es el ganador".Insert(6,Winner);

        }
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
