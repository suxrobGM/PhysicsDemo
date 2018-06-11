using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsDemo
{
    public class MoleculeVelocity
    {
        public const double R = 8.31;
        public double Temprature;
        public double MolarMass;

        public MoleculeVelocity()
        {
            this.Temprature = 273.0;
            this.MolarMass = 4.0;
        }

        public MoleculeVelocity(double Temprature, double MolarMass)
        {
            this.Temprature = Temprature;
            this.MolarMass = MolarMass;
        }

        public double CalcAverageVelocity()
        {            
            try
            {
                double v = Math.Sqrt((8 * R * Temprature) / (Math.PI * MolarMass));
                return v;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double CalcAverageVelocity(double Tempr, double MMass)
        {
            try
            {
                double v = Math.Sqrt((8 * R * Tempr) / (Math.PI * MMass));
                return v;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double CalcAverageSquareVelocity()
        {
            try
            {
                double v = Math.Sqrt((3 * R * Temprature) / MolarMass);
                return v;
            }
            catch (Exception ex)
            {
                throw ex;
            }                      
        }       

        public double CalcAverageSquareVelocity(double Tempr, double MMass)
        {
            try
            {
                double v = Math.Sqrt((3 * R * Tempr) / MMass);
                return v;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
