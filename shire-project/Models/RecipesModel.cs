﻿using System;

namespace shire_project.Models
{
    public class Recipes
    {

        public long ID { get; set; }
        public string Name { get; set; }

        //TODO: Add the rest of the properties once the DB connection is confirmed. Refactor to recipe 
        
        public Recipes()
        {

        }

        public override string ToString()
        {
            return $"ID is {ID}, Name is {Name}";
        }

    }
}
