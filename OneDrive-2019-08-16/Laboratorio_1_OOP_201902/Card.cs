﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Card
    {
        //Atributos
        protected string name;
        protected string type;
        protected string effect;

        //Constructor
        public Card(string name, string type, string effect)
        {
            this.name=name;
            this.type=type;
            this.effect=effect;
        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }
       

    }
}

