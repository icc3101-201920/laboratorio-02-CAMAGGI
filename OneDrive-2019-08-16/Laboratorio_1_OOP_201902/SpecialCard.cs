﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class SpecialCard : Card
    {
        //Atributos

        private string buffType;


        //Constructor
        public SpecialCard(string name, string type, string effect):base(name,type,effect)
        {
            buffType = null;
        }

    
        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }

    }
}