//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /*
    Por el patron expert esta es la clase que tiene la responsabilidad de calcular el total 
    de costo de producción porque es la experta en los datos necesarios ya que conoce 
    todos los steps.
    */
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Costo total de producción: '{this.GetProductionCost().ToString()}'");
        }

        public double GetProductionCost()
        {
            double result = 0;
            foreach(Step step in this.steps)
            {
                result += step.StepCost();
            }
            return result;
        }
    }
}