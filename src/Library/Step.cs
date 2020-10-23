//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        /*
        Se utilizo el patrón Expert, para asignarle a esta clase la responsabilidad 
        de calcular el precio de costo del step, debido a que esta clase es la 
        experta en la informacion necesitada para hacer este calculo.
        A su vez se aplica el principio SRP ya que la clase Step no tiene más de una razón de cambio al tener solo una responsabildiad(calcular el precio de costo del step)
        */
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        
        public double StepCost()
        {
            double inputCost = this.Input.UnitCost * this.Quantity;
            double equipmentCost = this.Equipment.HourlyCost * this.Time;
            return inputCost + equipmentCost;
        }
    }
}