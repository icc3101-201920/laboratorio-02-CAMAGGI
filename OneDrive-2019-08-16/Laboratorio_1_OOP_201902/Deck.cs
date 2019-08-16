
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Deck
    {
        protected List<CombatCard> combatCards01;
        protected List<SpecialCard> SpecialCards01;

        public Deck()
        {

        }

        public List<CombatCard> CombatCards
        {
            get => combatCards01; set => combatCards01 = value;
        }
        public List<SpecialCard> SpecialCards1
        {
            get => SpecialCards01; set => SpecialCards01 = value;
        }

        public void AddCombatCard(CombatCard combatCard)
        {
           combatCards01.Add(combatCard);
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
            SpecialCards01.Add(specialCard);
        }
        public void DestroyCombatCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
