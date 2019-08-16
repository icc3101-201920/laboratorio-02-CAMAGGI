using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }



        //Metodos
        public void AddCombatCard(int PlayerId, CombatCard combatCard)
        {
            string caseswitch = combatCard.Type;
            switch (caseswitch)
            { 
                case "melee":
                    meleeCards[PlayerId - 1].Add(combatCard);
                    break;
                case "range":
                    rangeCards[PlayerId - 1].Add(combatCard);
                    break;
                case "longrange":
                    longRangeCards[PlayerId - 1].Add(combatCard);
                    break;
                default:
                    break;


            }
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            captainCards.SetValue(specialCard,PlayerId-1);
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            weatherCards.Add(specialCard);
        }
        public void DestroyMeleeCard(int PlayerId)
        {
            meleeCards[PlayerId - 1].Clear();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            rangeCards[PlayerId - 1].Clear();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            longRangeCards[PlayerId - 1].Clear();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public int[,] GetMeleeAttackPoints()
        {
            int[,] MeleeAP;
            int meleeAtackPointsP0 = 0;
            int meleeAtackPointsP1 = 0;
            for (int i = 0; i < meleeCards[0].Count; i++)
            {
                meleeAtackPointsP0 += meleeCards[0][i].AttackPoints;
            }
            for (int i = 0; i < meleeCards[1].Count; i++)
            {
                meleeAtackPointsP1 += meleeCards[1][i].AttackPoints;
            }
            MeleeAP = new int[meleeAtackPointsP0, meleeAtackPointsP1];
            return MeleeAP;

        }
        public int[,] GetRangeAttackPoints()
        {
            
            int[,] RangeAP;
            int rangeAtackPointsP0 = 0;
            int rangeAtackPointsP1 = 0;
            for (int i = 0; i < rangeCards[0].Count; i++)
            {
                rangeAtackPointsP0 += rangeCards[0][i].AttackPoints;
            }
            for (int i = 0; i < rangeCards[1].Count; i++)
            {
                rangeAtackPointsP1 += rangeCards[1][i].AttackPoints;
            }
            RangeAP = new int[rangeAtackPointsP0, rangeAtackPointsP1];
            return RangeAP;
            
        }
        public int[,] GetLongRangeAttackPoints()
        {
            int[,] LRangeAP;
            int longRangeAtackPointsP0 = 0;
            int longRangeAtackPointsP1 = 0;
            for (int i = 0; i < rangeCards[0].Count; i++)
            {
                longRangeAtackPointsP0 += longRangeCards[0][i].AttackPoints;
            }
            for (int i = 0; i < rangeCards[1].Count; i++)
            {
                longRangeAtackPointsP1 += longRangeCards[1][i].AttackPoints;
            }
            LRangeAP = new int[longRangeAtackPointsP0, longRangeAtackPointsP1];
            return LRangeAP;
        }
    }
}
