﻿using System;
using System.Collections.Generic;

namespace Laboratorio_1_OOP_201902
{
    public class Deck
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> SpecialCards;

        public Deck()
        {

        }

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards1 { get => SpecialCards; set => SpecialCards = value; }

        public void AddCombatCard(int playerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
            throw new NotImplementedException();
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
