using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field.P1
{
    class IdealGas
    {
        /*----------------------------------- Private Methods, Setters, Getters -----------------------------------*/

        //----------------------------
        //Mass
        //----------------------------
        private double mass;
        public Double GetMass()
        {
            return mass;
        }
        public void SetMass(double mass)
        {
            this.mass = mass;
            Calc();
        }

        //---------------------------
        //Volume
        //---------------------------
        private double vol;
        public Double GetVol()
        {
            return vol;
        }
        public void SetVol(double vol)
        {
            this.vol = vol;
            Calc();
        }

        //----------------------------
        //Temperature
        //----------------------------
        private double temp;
        public Double GetTemp()
        {
            return temp;
        }
        public void SetTemp(double temp)
        {
            this.temp = temp;
            Calc();
        }

        //--------------------------------
        //Molecular Weight
        //--------------------------------
        private double molecularWeight;
        public Double GetMolecularWeight()
        {
            return molecularWeight;
        }
        public void SetMolecularWeight(double molecularWeight)
        {
            this.molecularWeight = molecularWeight;
            Calc();
        }

        //-----------------------------
        //Pressure      
        //-----------------------------
        private double pressure;
        public Double GetPressure()
        {
            return pressure;
        }
   
        /*---------------------------------------- Privot Methods --------------------------------------------------------*/

        //-----------------------------------
        //Calculation Method
        //-----------------------------------
        private void Calc()
        {
            double mol = mass;
            double kelvin = temp;
            double celcius = kelvin;
            double R = 8.3145;

            //Calculate: pressure in pascals
            double pressure = (mol * R * kelvin) / vol;
        }

    }
}
